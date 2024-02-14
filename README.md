# RickAndMorty API Backend App
[RickAndMorty API](https://rickandmortyapi.com/)

Bu proje, popüler TV serisi Rick and Morty hakkındaki bilgilere erişim sağlamak için .NET Core ve Rick and Morty API kullanılarak geliştirilmiş bir web uygulamasıdır. Kullanıcılar bu uygulama üzerinden karakterler, Episodes ve daha fazlası hakkında detaylı bilgilere ulaşabilirler.

## Başlarken

Bu bölüm, projeyi yerel geliştirme ortamınızda nasıl kurup çalıştıracağınızı açıklar.

### Gereksinimler

Projeyi çalıştırmak için aşağıdaki araçların kurulu olması gerekmektedir:

- .NET Core 3.1 SDK (veya daha yeni)
- Git

### Kurulum

Projeyi yerel makinenize klonlamak ve çalıştırmak için aşağıdaki adımları izleyin:

1. Projeyi klonlayın:
    ```bash
    git clone https://github.com/suleymanbeyaz10/rickandmorty.git
    cd rickandmorty
    ```
2. Bağımlılıkları geri yükleyin:
    ```bash
    dotnet restore
    ```
3. Uygulamayı çalıştırın:
    ```bash
    dotnet run
    ```
## Kullanım

Bu bölüm, web uygulamasının temel kullanımı hakkında bilgiler içerir.

### Characters

Characters sayfasında, Rick and Morty evrenindeki tüm karakterler listelenir. Karakterler hakkında ad, tür ve mevcut durum gibi bilgiler görüntülenir.

### Episodes

Episodes sayfasında, dizinin tüm bölümleri listelenir. Kullanıcılar bölüm adı, yayın tarihi ve bölüm numarası gibi detaylara erişebilir.

## Katkıda Bulunma

Projeye katkıda bulunmak isteyenler için adımlar:

1. Projeyi forklayın.
2. Feature branch'i oluşturun (`git checkout -b feature/AmazingFeature`).
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`).
4. Branch'inize Push yapın (`git push origin feature/AmazingFeature`).
5. Yeni bir Pull Request oluşturun.

## Teşekkürler
