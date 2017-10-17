# CommonMistakes1

Merhabalar Ben Hüseyin, Bazen kayan değerler ile işlem yaptığımızda işlem ne kadar doğru olduğunu bilsekte, bazen bilgisayar düşündüğümüz gibi yapamıyor.

1 sayısından 10 kere 0.1 değerinin çıkardığımızdan mantık ile sonucun 0 olduğunu düşünürüz. Ama bilgisayar bizden farklı düşününyor.

sonuç 0 iken, ve kontroller ile yanlış bir deyim tanımlamışsak (num == 0), programın hatasını nerede olduğunu anlaşılması zor.

bunun ana sebebi kullandığımız microişlemcilerimiz 0 ve 1 lerden anlıyor. Bu nedenler tam sayıların tanılması kolay, ama kayan değerlerin 0 ve 1 (Makine dilinde) de bir karşılığı yok.

Çözüm; Kontrollerimizi daha dinamik tutmamız lazım. "if(num < 0.1 && num >0.11)" gibi
