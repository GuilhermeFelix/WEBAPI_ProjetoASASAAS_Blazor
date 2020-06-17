using System.Collections.Generic;

namespace Frontend.imanager.Entities
{
    public class NewSaas
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Crm_START { get; set; }
        public bool Vendas_START { get; set; }
        public bool Faturamento_START { get; set; }
        public bool Site_START { get; set; }
        public string IPV4 { get; set; }
        public int PORT { get; set; }
        public int LICENSES { get; set; }
        public string TAG { get; set; }
    }
}
