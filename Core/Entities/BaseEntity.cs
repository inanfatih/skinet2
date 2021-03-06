namespace Core.Entities
{
    public class BaseEntity
    {
        // c#'ta conventional olarak Pascal casing kullaniliyor. Yani property'lerin ve variable'larin her kelimesinin ilk harfi buyuk yaziliyor
        // Id isimli column u Entity Framework otomatik olarak primary key olarak atiyor.
        public int Id { get; set; }
    }
}