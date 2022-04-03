#Dependency Inversion Prenciple

High Level (Dışardan alınan sınıfın kullanıcısı) sınıflar, Low-Lewl (Dışarıdan alınan )sınıflara bağlı olmamalıdır.İlişki abstraction veya interface kullanarak sağlanmalıdır.
Abstraction  detaylara bağlı olmamalıdır, tam tersi detaylar abstractionlara bağlı olmalıdır. Bir classda nesne örneği oluşturmak , iki classın birbirini tanımasına ve birbirine bağımlı olmasına neden olur. Bir class da yapılan değişiklik diğer classı da etkileyecektir.Bağımlılığı ortadan kaldırmak için iki classı birbirinden soyutlamalıyız. Bunun için araya abstraction ekleyerek ,nesne örneği üretimini abtraction yapısına vermeliyiz. 
