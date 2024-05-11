# Chain Of Responsibility Projesi
MY Academy kapsamında katılmış olduğum eğitimin bir projesi olan Chain Of Responsibility projesini hayata geçirdim. Kredi çekme işlemi özelinde bu Design Pattrn örenğini oluşturdum.


# Senaryo
Bu sistem, müşterilerin istedikleri kredi miktarını belirlemelerine ve bu isteklerin banka çalışanları tarafından sırasıyla değerlendirilmesine olanak tanır. Kredi onay süreci, her banka çalışanının belirli bir yetki limitine sahip olduğu hiyerarşik bir yapı üzerine kuruludur. Bu yapı, kredi isteklerinin daha etkili ve verimli bir şekilde yönetilmesini sağlar.

# 🚀 Kredi İstek Süreci:
## 1. Kredi Talebi Girişi:

Müşteriler, bankanın sağladığı bir arayüz üzerinden çekmek istedikleri kredi miktarını girer. Bu talep, sistem tarafından otomatik olarak ilk kontrol noktasına, yani uygun banka çalışanına yönlendirilir.

## 2. Kredi Değerlendirme ve Yönlendirme:

Her banka çalışanının, kredi onaylamak için belirlenmiş bir üst limiti vardır. Bir çalışanın kredi onay limiti, müşterinin talep ettiği miktarı karşılıyorsa, kredi onaylanır ve süreç sona erer.
Eğer talep edilen kredi miktarı, mevcut çalışanın onay limitini aşıyorsa, kredi isteği otomatik olarak bir sonraki yetki seviyesindeki çalışana iletilir. Bu işlem, kredi onayı alınana kadar veya en üst yetki seviyesine ulaşılana kadar devam eder.

## 3. Kredi Onayı veya Reddi:

Kredi isteği, uygun yetki seviyesindeki bir çalışan tarafından onaylandığında, müşteriye kredi onaylandığına dair bilgilendirme yapılır.
Eğer kredi, en üst seviyedeki çalışan tarafından dahi onaylanmazsa, müşteriye kredi reddedildiğine dair bilgilendirme yapılır ve gerekçeleri açıklanır.


# Chain Of Responsibility

Chain of Responsibility (Sorumluluk Zinciri), bir isteğin birden fazla nesne tarafından işlenebilmesi için kullanılan bir tasarım desenidir. Bu desen, isteği işleyebilecek nesneleri bir zincir olarak düzenler ve isteği zincir üzerindeki nesnelerden biri tarafından işlenene kadar bir sonraki nesneye aktarır.

Bu yapı, bir isteğin işlenme şeklini değiştirmeyi veya genişletmeyi kolaylaştırır çünkü istekleri işleyecek nesneler arasında gevşek bir bağlantı kurar. Böylece, yeni işleyiciler eklemek veya mevcutları çıkarmak kolaylaşır, ve sistemin bakımı ve genişletilmesi daha esnek hale gelir.

Chain of Responsibility, özellikle farklı işlemlerin veya onayların farklı kurallar veya limitler gerektirdiği durumlarda etkilidir. Örneğin, bir bankacılık uygulamasında, farklı yetki seviyelerine sahip çalışanlar tarafından işlenmesi gereken kredi onay süreçlerinde kullanılabilir. Bu desen, kodun tekrar kullanılabilirliğini ve sistemin genel yalınlığını artırarak, daha temiz ve yönetilebilir yazılım mimarileri oluşturulmasına yardımcı olur.



******************************************

![Project GIF](https://github.com/talhayildiz99/ChainOfResponsibility/assets/84921617/f3b30198-ac97-4524-9e2a-357c7cfc0da0)


******************************************

![Data](https://github.com/talhayildiz99/ChainOfResponsibility/assets/84921617/3ec40ba9-9776-4245-9622-9cdce354b2d4)

******************************************
