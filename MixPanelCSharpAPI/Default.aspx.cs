using Mixpanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MixPanelCSharpAPI {
    //PM> Install-Package mixpanel-csharp
    //https://www.nuget.org/packages/mixpanel-csharp/

    // EXEMPLO 01:
    //   mixpanel.track("Assinatura", {
    //       "tpPagamento": "Boleto",
    //       "idPlano": "01"
    //   });

    // EXEMPLO 02:
    //   mixpanel.track("Assinatura", {
    //       "tpPagamento": "Cartão",
    //       "idPlano": "01"
    //   });

    //Outros links:
    //Guide: https://mixpanel.com/help/reference
    //https://github.com/eealeivan/mixpanel-csharp
    //https://github.com/chrisnicola/Mixpanel.NET

    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }

        //LEMBRAR DE ADCIONAR <%@ Page Async="true" %> na pagina ASPX
        protected async void Button1_Click(object sender, EventArgs e) {
            var mc = new MixpanelClient("[API TOKEN]");
            await mc.TrackAsync("Assinatura", new {
                idPlano = "12345",
                dtPagamento = DateTime.Now,
                tpPagamento = "Boleto"
            });
        }

        //RESULT JSON:
        //{
        //  "event": "Assinatura",
        //  "properties": {
        //    "token": "",
        //    "idPlano": "12345",
        //    "dtPagamento": "2015/06/06 00:00:00",
        //    "tpPagamento": "Boleto"
        //  }
        //}
    }
}