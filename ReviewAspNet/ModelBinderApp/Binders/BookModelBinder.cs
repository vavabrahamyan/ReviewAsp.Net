using ModelBinderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinderApp.Binders
{
    public class BookModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var valueProvider = bindingContext.ValueProvider;

            ValueProviderResult vprId = valueProvider.GetValue("Id");

            string name = (string)valueProvider.GetValue("Name").ConvertTo(typeof(string));
            string author = (string)valueProvider.GetValue("Author").ConvertTo(typeof(string));
            int year = (int)valueProvider.GetValue("Year").ConvertTo(typeof(int));

            Book book = new Book { Name = name + "{new}", Author = author, Year = year };

            if (vprId != null)
            {
                book.Name = name;
                book.Id = (int)valueProvider.GetValue("Id").ConvertTo(typeof(int));
            }
            return book;
        }
    }
}