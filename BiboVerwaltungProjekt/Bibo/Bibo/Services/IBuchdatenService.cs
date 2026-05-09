using Bibo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Services
{
    public interface IBuchdatenService
    {
        BuchdatenViewModel GetBuchdaten(string isbn);
    }
}
