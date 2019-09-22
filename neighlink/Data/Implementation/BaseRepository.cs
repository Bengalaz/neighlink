using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementation
{
    public class BaseRepository
    {
        protected NeighlinkDBContext context;
        public BaseRepository()
        {
            context = new NeighlinkDBContext();
        }
    }
}
