using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
       
        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmamaktadır.";
        public static string StatusNameAlreadyExists = "Durum ismi zaten mevcut.";
        public static string StatusAdded = "Durum başlığı başarı ile eklendi.";
        public static string StatusUpdated = "Durum başlığı başarı ile güncellendi";

        public static string UserRegistered = "Kullanıcı başarı ile kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı şifre!";
        public static string LoginSuccessfull = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu.";
    }
}
