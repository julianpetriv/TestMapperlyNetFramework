using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMapperlyNetFramework
{
    [Mapper]
    public partial class TestMapper
    {
        public partial Dog MapAnimalToDog(Animal animal);
    }
}
