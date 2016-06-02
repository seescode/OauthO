using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Thinktecture.IdentityModel.Client;

namespace OauthO.Controllers
{
    public class OauthController : Controller
    {
		private string _clientId = "FIX_ME";
	    private string _clientSecret = "FIX_ME";
	    private string _redirectUri = "FIX_ME";
	    private string _githubOauthAuthorizeUrl = "FIX_ME";

		public ActionResult StepOne()
		{
			OAuth2Client client = new OAuth2Client(new Uri(_githubOauthAuthorizeUrl));

			var url = client.CreateCodeFlowUrl(
				_clientId,
				"repo:status",
				_redirectUri,
				"",
				null,
				null,
				null,
				null);

			return Redirect(url);
		}

		public async Task<ActionResult> StepTwo(string code)
		{
			ViewBag.AuthCode = code;

			return View();
		}
	}
}