using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPesanan, string IDLokasi);
        [OperationContract]
        string editpemesanan(string IDPemesanan, string NamaCustomer);
        [OperationContract]
        string deletepemesanan(string IDPemesanan);
        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //menampilkan data di database
        [OperationContract]
        List<DetailLokasi> DetailLokasi();
        [OperationContract]
        List<Pemesanan> Pemesanan();
    }
    [DataContract]
    public class CekLokasi //daftar lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }
    [DataContract]
    public class DetailLokasi //menampilkan detail lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; }
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiFull { get; set; }
        [DataMember]
        public int Kuota { get; set; }
    }
    [DataContract]
    public class Pemesanan //create
    {
        [DataMember]
        public string IDPemesanan { get; set; }
        [DataMember]
        public string NamaCustomer { get; set; }
        [DataMember]
        public string NoTelpon { get; set; }
        [DataMember]
        public int JumlahPemesanan { get; set; }
        [DataMember]
        public string IDLokasi { get; set; }
    }
}
