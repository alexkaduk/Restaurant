using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuPlanner.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
        public int Active { get; set; }
        public int Order { get; set; }
        public int Type { get; set; }
        public DateTime? Day { get; set; }

        public int MenuCardId { get; set; }
        public virtual MenuCard MenuCard { get; set; }
    }

    public class MenuCard
    {
        // https://msdn.microsoft.com/ru-ru/data/jj193542.aspx
        // https://www.youtube.com/watch?v=nDYU9gYYAHY
        public int Id { get; set; }
        public string Name { get; set; }
        public int Active { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
    }
}