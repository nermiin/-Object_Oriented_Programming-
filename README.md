Bir otomobil simülasyon programı yazmak için gerekli sınıfların ve ara yüzlerin (interface) oluşturulmuştur. 
Simülasyon programı YAZILMADI, sadece gerekli sınıflar ve ara yüzler (interface’ler) oluşturuldu ve üyeleri (özellikleri, metotları vs.) yazıldı. 
Ayrıca sınıfların UML sınıf diyagramı çizilecektir. 
Elektronik Beyin 
Bütün elektronik parçaları beyin kontrol edecektir. Örneğin gaz pedalına basıldığında bu bilgi beyne iletilecek, beyin de eğer araç çalışıyorsa bu bilgiyi motora iletecek, çalışmıyorsa göz ardı edecektir. Ya da örneğin sinyal kumanda kolundan sola sinyal verildiğinde bu bilgi beyne iletilecek, beyin de sinyal lambalarını yakacaktır. 
Motor 
Simülasyonda kullanıcının motor tipini seçmesine izin verileceği düşünülerek, hem benzinli hem de dizel motor tasarlanacaktır. Gaza basıldığında dizel motorlarda aracın hızı 8 km/s, benzinli motorlarda ise 10 km/s artacaktır. 
Kontak Anahtarı 
“Açık/Kapalı” şeklinde çalışacaktır. Kontak açık iken tüm parçalar, kapalı iken sadece farlar ve sinyaller çalışacak, diğer bütün parçalar işlevsiz kalacaktır. Araç hareket halinde iken kontak kapatılamayacaktır. 
Gaz Pedalı 
“Basıldı/Basılmadı” şeklinde çalışacaktır. Gaz pedalına basıldığında araç motor çeşidine göre belirli bir miktar hızlanacaktır. 
Fren Pedalı 
“Basıldı/Basılmadı” şeklinde çalışacaktır. Fren pedalına basıldığında araç 10 km/s yavaşlayacaktır. 
Direksiyon 
“Sağa Dönük/Sola Dönük/Düz” şeklinde çalışacaktır. Direksiyon sağa ya da sola döndürüldüğünde tekerin açısı 5 derece değişecektir. 
Tekerlekler 
Tekerleklerin her iki yöne de dönüş açısı en fazla 45 derece olabilir. 
Hız Göstergesi 
Kontak açıkken aracın hızını gösterecektir. 
Farlar 
Araçta hem kısa hem de uzun farlar bulunacaktır.  
Far kumanda kolu 
“Kapalı/Kısa Farlar Açık/Uzun Farlar Açık” şeklinde çalışacaktır. 
Sinyal Lambaları 
Araçta sağ ve sol sinyal lambaları bulunacaktır. Sinyal lambalarının yanıp sönmesi için elektriğin kesik kesik verilmesine gerek yoktur. Kesintisiz bir şekilde elektrik verildiğinde yanıp sönme işlevini kendi içinde yaptığı varsayılacaktır. 
Sinyal Kumanda Kolu 
“Kapalı/Sol Sinyal Açık/Sağ Sinyal Açık/Dörtlü Sinyal Açık” şeklinde çalışacaktır. 
OTOMOBİLİN ÇALIŞMASI İLE İLGİLİ EK BİLGİLER • Gaz ve fren pedalları sadece aracın hızını değiştirmek için kullanılacaktır. Herhangi bir pedala basılmadığı sürece aracın aynı hızda ilerlemeye devam ettiği varsayılacaktır. • Otomobil en fazla 220 km/s hız yapabilecektir. En yüksek hıza ulaştıktan sonra gaza basılsa bile araç hızlanmamalıdır. • Aracın geri geri gidemediği varsayılacaktır. 
