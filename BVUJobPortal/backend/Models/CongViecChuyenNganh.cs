using BVUJobPortal.Models;

public class CongViecChuyenNganh
{
    public int Id { get; set; }
    public int CongViecId { get; set; }
    public CongViec CongViec { get; set; }

    public int ChuyenNganhId { get; set; }
    public ChuyenNganh ChuyenNganh { get; set; }
}