# Bridge Design Pattern
   Büyük bir sınıfı veya yakından ilişkili bir dizi sınıfı birbirinden bağımsız olarak geliştirilebilen soyutlama ve uygulama olmak üzere iki ayrı hiyerarşiye ayırmanıza  olanak tanıyan yapısal bir tasarımdır  modelidir.Soyutlama ve uygulamanın bağımsız olarak geliştirilmesine izin verir. Soyutlama , uygulayıcıya bir referans içerir. Soyutlamanın child sınıfları rafine soyutlama olarak adlandırılır.Soyutlamayı genişletir. Client sadece soyutlama kısmına erişebilir, uygulama kısmını bilmez.Soyutlama bir arayüz veya soyut bir snıftır ve uygulayıcı da bir arayüz veya soyut bir sınıftır.Uygulamanın child sınıfları concrete (somut) uygulayıcılardır. Uygulayıcıda yapılan değişiklikler Client kodunu etkilemez.Soyutlama ve uygulama arasında loose coupling (gevşek bağlantı) vardır.



![Bridge](https://user-images.githubusercontent.com/94036242/160546928-82df4cd2-4848-4a86-b635-27a5d6a03857.gif)


Bridge Desingn Pattern UML Şeması
