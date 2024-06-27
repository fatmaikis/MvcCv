# MVC 5 İle Dinamik Admin Panelli Cv Sitesi 
Merhaba, kendi bilgilerim ile bütünleştirdiğim bir cv sitesi projesidir. Bu proje de hakkımda, 
eğitimlerim, deneyimlerim, hobilerim, yeteneklerim, sertifikalarım, iletişim bilgilerim, sosyal medya hesaplarım
gibi sayfalar yer almaktadır. Bu projede neler yaptığımı ve hangi teknolojileri kullandığımı detaylı açıklayacağım ;

- ORM: Entity Framework Code First yaklaşımı kullanılmıştır.
- Veritabanı: MSSQL Server kullanılmıştır.
- Yetkilendirme: Admin tarafı için Authorize özelliği entegre edilmiştir. Admin paneline erişmek için kullanıcı adı ve şifre giriş yapılabilmektedir. Admin değil ise panele erişimi
sağlanmamaktadır.
- Giriş/Çıkış: Kullanıcılar için login ve logout işlemleri bulunmaktadır.
- Kullanıcı Arayüzü: Admin ve son kullanıcı olmak üzere iki farklı kullanıcı arayüzü mevcuttur.
- Oturum Yönetimi: Session yönetimi kullanılmıştır.
- Validation Kontrolleri (Required ve MaxLength) kullanılmıştır.
- Admin tarafında modal popup kullanılmıştır.
- Repository Design Pattern kullanılmıştır.

## Ekran Görüntüleri
* İlk olarak hakkımda sayfası yer almaktadır. Buradan hakkımda ki bilgilere ve sosyal medya hesaplarıma erişim sağlayabilmektedir. 
![1](https://github.com/fatmaikis/MvcCv/assets/77547782/000fe030-f053-496b-9379-cee84a8f2e50)

* Deneyimlerim sayfasını görüntüleyebilmektedir. 
  ![2](https://github.com/fatmaikis/MvcCv/assets/77547782/261b9b8d-a5c7-40e3-8f21-a58bf9988c80)

* Eğitimlerim sayfasını görüntüleyebilmektedir
  ![3](https://github.com/fatmaikis/MvcCv/assets/77547782/0d9e885d-30fb-41bf-a83e-f1e76e367930)

* Yeteneklerim sayfasını görüntüleyebilmektedir. 
   ![4](https://github.com/fatmaikis/MvcCv/assets/77547782/d5c548e4-0b3d-4792-9cc8-8a3aa36bb008)

* Hobilerim sayfasını görüntüleyebilmektedir. 
   ![5](https://github.com/fatmaikis/MvcCv/assets/77547782/08f2b24d-5e4c-49b0-aea8-268ccafdcd86)

* Sertifikalarım sayfasını görüntüleyebilmektedir. 
   ![6](https://github.com/fatmaikis/MvcCv/assets/77547782/908fd53d-2a8c-4283-b9cd-b0e60b53c257)

* İletişim ssayfasını görüntüleyebilmektedir. Admine ad soyad, mail, konu ve mesaj yazarak ulaşım sağlayabilmektedir.
   ![7](https://github.com/fatmaikis/MvcCv/assets/77547782/10c3154c-c45a-4629-8a82-faac52c96b95)

* Admin paneline erişim sağlamak için kullanıcı adı ve şifre ile giriş yapılmaktadır. 
   ![8](https://github.com/fatmaikis/MvcCv/assets/77547782/7530b637-330c-40c1-aa7c-c9e3b964e2e3)

* Hakkımda sayfasında verileri güncelleyebilmektedir.
  ![10](https://github.com/fatmaikis/MvcCv/assets/77547782/6ec825bd-624c-444c-94fe-16f586746dfb)

* Eğitim sayfasına veri ekleyebilir, silebilir ve güncelleyebilir.
  ![11](https://github.com/fatmaikis/MvcCv/assets/77547782/b2c4ea41-e9a1-4462-80b8-8e379d54d55a)

  ![11 5](https://github.com/fatmaikis/MvcCv/assets/77547782/dfa0d71d-954f-4d9c-a07d-3b3801f79094)

* Deneyim sayfasına veri ekleyebilir, silebilir ve güncelleyebilir.
  ![12](https://github.com/fatmaikis/MvcCv/assets/77547782/5c97c142-df10-414a-8a96-dfa83125d269)

  ![12 5](https://github.com/fatmaikis/MvcCv/assets/77547782/24b1110e-291a-40b5-8e9e-d5c53855139b)

* Hobilerim sayfasında ki verileri güncelleyebilmektedir.
  ![13](https://github.com/fatmaikis/MvcCv/assets/77547782/6fd288be-f14a-43ce-bd38-58476bebf05d)

* Yetenek sayfasına veri ekleyebilir, silebilir ve güncelleyebilir.
  ![14](https://github.com/fatmaikis/MvcCv/assets/77547782/bf7183be-46f3-4b47-869d-a85dd6101220)

  ![14 5](https://github.com/fatmaikis/MvcCv/assets/77547782/54c611b0-90f5-442e-9dcd-2ff807630555)

* Sertifikaları görüntüleyebilir ve yeni sertifika ekleyebilmektedir.
  ![15](https://github.com/fatmaikis/MvcCv/assets/77547782/43e6c595-6470-42f4-b214-b3bba3c54906)

  ![15 5](https://github.com/fatmaikis/MvcCv/assets/77547782/3d27725f-d6d8-44fd-8114-c8a75cc98a69)


* Mesajları görüntüleyebilir ve mesaj ekleyebilmektedir.
  ![16](https://github.com/fatmaikis/MvcCv/assets/77547782/10dff3a0-4026-471d-acc9-a8b81fbd8ec7)

* Sosyal medya hesapları sayfasına veri ekleyebilir, silebilir ve güncelleyebilir.
  ![17](https://github.com/fatmaikis/MvcCv/assets/77547782/7ba9bf1d-6e67-4e07-8179-16673ed0b3f3)
  ![17 5](https://github.com/fatmaikis/MvcCv/assets/77547782/bd6357f1-9c13-4140-a9e5-723621202d23)

* Kullanıcı sayfasına veri ekleyebilir, silebilir ve güncelleyebilir.
  ![18](https://github.com/fatmaikis/MvcCv/assets/77547782/0e0f70df-8b0f-4c2e-8d80-ad86d81e1ade)
  ![18 5](https://github.com/fatmaikis/MvcCv/assets/77547782/e634d6dd-610f-4ce9-b8f0-9c52e6821db7)



