using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericReporsitoryPattern.IntRep
{
    public interface IRepository<T> where T: BaseEntity
    {


        // List Comand

        List<T> GetAll(); // Bu metot T ne olursa o verileri getirecek.



        // Modify Commands

        void Add(T item);

        void AddRange(List<T> list);

        void Update(T item); // Bu metot ilgili nesne koleksiyonunu güncellemek için tasarlandı.

        void UpdateRange(List<T> list); // Bu metot ilgili nesne koleksiyonunu güncellemek için tasarlandı.

        void Destroy(T item); //bu metot veriyi yok etmek için tasarlanıyor.



        // Linq Expressions

        List<T> Where(Expression<Func<T, bool>> exp); // Bu metot Expression alarak belirtilen veriye göre bir veri koleksiyonu döndürür.

        bool Any(Expression<Func<T, bool>> exp); // Bu metot Expression alarak belirtilen verinin veritabanında var mı, yok mu bunu belirtir. (Olumlu veya olumsuz dönüş sağlar.)

        T FirstOrDefult(Expression<Func<T, bool>> exp); // Bu metot sizin verdiğiniz Expression belirtecine göre tekil bir nesne döndürecektir veya bu Expression ifadesine göre bir nesne bulamazsa null döndürecektir.

        object Select(Expression<Func<T, object>> exp); // Bu metot anonymus tip dahil tüm tiplere destek verip buna göre bir sorgulama yapılabilmesi için tasarlanmıştır.



        // Find

        T Find(int id); // Verdiğimiz Primary Key'e göre tekil bir nesne döndürecektir.

        //Get The Counted Datas

        List<T> GetDatas(int number); // Bu metot verilerden istediğiniz kadarını(verdiğiniz parametreyi baz alarak) döndürecektir.
    }
}
