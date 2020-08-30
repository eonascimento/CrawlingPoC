using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlingPoC.Api.ViewModels
{
    public class SharesResultViewModel
    {
        public SharesResultViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string AcronymShare { get; set; }
        public string NameShare { get; set; }
    }
}
