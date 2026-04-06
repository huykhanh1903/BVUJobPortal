using BVUJobPortal.Data;
using BVUJobPortal.Mappings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using QuestPDF.Infrastructure;
using BVUJobPortal.Middleware;
using Microsoft.Extensions.FileProviders;
using BVUJobPortal.Services.CongViec;
using BVUJobPortal.Services.Admin;
using BVUJobPortal.Services.DoanhNghiep;
using BVUJobPortal.Services.TaiKhoan;
using BVUJobPortal.Services.DiaChi;
using BVUJobPortal.Helpers;
using Microsoft.Extensions.Options;
using BVUJobPortal.Services.TuKhoa;
using BVUJobPortal.Services.CvModule;
using BVUJobPortal.Services.SinhVien;
using BVUJobPortal.Services.UngTuyen;
using BVUJobPortal.Services.ThongBao;
using BVUJobPortal.Services.BaoCao;
using BVUJobPortal.Services.Email;
using BVUJobPortal.Settings;
using BVUJobPortal.Services.AI;
using BVUJobPortal.Services.System;
using BVUJobPortal.Services.UngVien;


var builder = WebApplication.CreateBuilder(args);

// Load JWT settings
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));
builder.Services.AddSingleton(resolver =>
    resolver.GetRequiredService<IOptions<JwtSettings>>().Value);

// DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptions => sqlServerOptions.CommandTimeout(180)));

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings")
);

// Service
builder.Services.AddScoped<ITaiKhoanService, TaiKhoanService>();
builder.Services.AddScoped<ICVService, CVService>();
builder.Services.AddScoped<ICongViecService, CongViecService>();
builder.Services.AddScoped<IUngTuyenService, UngTuyenService>();
builder.Services.AddScoped<IThongBaoService, ThongBaoService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IBaoCaoService, BaoCaoService>();
builder.Services.AddScoped<ICVTemplateService, CVTemplateService>();
builder.Services.AddScoped<ICVService, CVService>();
builder.Services.AddScoped<ICVTemplateAdminService, CVTemplateAdminService>();
builder.Services.AddScoped<IDoanhNghiepService, DoanhNghiepService>();
builder.Services.AddScoped<IDiaChiService, DiaChiService>();
builder.Services.AddScoped<ITuKhoaService, TuKhoaService>(); 
builder.Services.AddScoped<ISinhVienProfileService, SinhVienProfileService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IAIService, AIService>();
builder.Services.AddScoped<SystemConfigService>();
builder.Services.AddScoped<IUngVienService, UngVienService>();




// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials();
        });
});

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

QuestPDF.Settings.License = LicenseType.Community;



// JWT
var jwtSection = builder.Configuration.GetSection("Jwt");
var keyBytes = Encoding.UTF8.GetBytes(jwtSection["Key"]!);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(o =>
    {
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidateLifetime = true,
            ValidIssuer = jwtSection["Issuer"],
            ValidAudience = jwtSection["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
            ClockSkew = TimeSpan.Zero
        };
    });


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BVU Job Portal API", Version = "v1" });

    // Cau hinh JWT Bearer
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        Scheme = "bearer",
        BearerFormat = "JWT",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Description = "Nhập: Bearer {token}",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider=new PhysicalFileProvider(Path.Combine(builder.Environment.WebRootPath, "uploads")),
    RequestPath = "/uploads"
});


app.UseCors("AllowFrontend");

app.UseAuthentication();
app.UseMiddleware<CheckUserLockMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
