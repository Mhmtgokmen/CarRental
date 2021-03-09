using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{//sürekli new lemek için static yapıyoruz 
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";

        public static string BrandNameInvalid = "Marka ismi geçersiz en az 2 karakter olmalı";

        public static string BrandNameAdded = "Marka eklendi";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarListed = "Arabalar listelendi";

        public static string CarNotListed = "Arabalar listelenemedi";

        public static string CarDeleted = "Araba silindi";

        public static string CarNotDeleted = "Araba silinemedi";

        public static string CarUpdated = "Araba güncellendi";

        public static string CarNotUpdated = "Araba güncellenemedi";

        public static string ColorAdded = "Ekleme işlemi başarılı";

        public static string ColorNameInvalid = "Renk ismi geçersiz en az iki karakter olmalı";

        public static string RentalAdded = "Kiralama işlemi başarılı";

        public static string RentalInvalid = "Kiralama geçersiz.Arabanın teslim edildiğnden emin olun";

        public static string RentalListed = "Tüm kiralama işlemleri listelendi";

        public static string UserAdded = "Giriş başarılı";

        public static string ImageInsertionLimit = "Resim ekleme sınırına ulaşıldı daha fazla eklenemez";

        public static string AddCarImageMessage = "Araç resmi başarılı şekilde eklendi";

        public static string DeleteCarImageMessage = "Araç resmi başarılı şekilde silindi ";

        public static string UpdateCarImageMessage = "Araç resmi başarılı şekilde güncellendi";
        
        public static string UserNameAlreadyExists="Bu isimde başka bir kullanıcı var";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered= "Kullanıcı başarıyla kaydedildi";

        public static string UserNotFound= "Kullanıcı bulunamadı";

        public static string PasswordError= "Şifre hatalı";
        
        public  static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        
        public static string AccessTokenCreated= "Access token başarıyla oluşturuldu";

        public  static string SuccessfulLogin= "Sisteme giriş başarılı";
    }
}
