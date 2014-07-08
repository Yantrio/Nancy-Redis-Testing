using System;
using System.Globalization;

namespace Nancy_Redis_Testing
{
  using Nancy;

  public class IndexModule : NancyModule
  {
    public IndexModule()
    {
      Get["/"] = parameters => View["index"];

      Get["SessionTest/{key}"] = args =>
      {
        if (Request.Session[args.key] == null)
        {
          Request.Session[args.key] = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }
        return Request.Session[args.key];
      };
    }
  }
}