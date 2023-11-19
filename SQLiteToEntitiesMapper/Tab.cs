using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteToEntitiesMapper
{
    class Tab
    {
        private int tabLevel;

        public Tab()
        {
            this.tabLevel = 0;
        }

        public Tab(int tabLevel)
        {
            this.tabLevel = tabLevel;
        }

        public static Tab operator +(Tab tab, int increment)
        {
            return new Tab(tab.tabLevel + increment);
        }

        public static Tab operator ++(Tab tab)
        {
            return new Tab(tab.tabLevel + 1);
        }

        public static Tab operator -(Tab tab, int increment)
        {
            return new Tab(tab.tabLevel - increment);
        }

        public static Tab operator --(Tab tab)
        {
            return new Tab(tab.tabLevel - 1);
        }

        public override string ToString()
        {
            return string.Join("", Enumerable.Repeat("\t", tabLevel));
        }
    }
}
