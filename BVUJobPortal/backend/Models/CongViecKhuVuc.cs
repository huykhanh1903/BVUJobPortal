using BVUJobPortal.Models;

public class CongViecKhuVuc
{
    public int Id { get; set; }

    public int CongViecId { get; set; }
    public CongViec CongViec { get; set; }

    public int TinhThanhId { get; set; }
    public TinhThanh? TinhThanh { get; set; }

    public string? DiaChiCuThe { get; set; }
}