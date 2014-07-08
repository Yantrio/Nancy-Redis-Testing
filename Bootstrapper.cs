using Nancy.Bootstrapper;
using Nancy.Session;
using Nancy.TinyIoc;
using Nancy;

namespace Nancy_Redis_Testing
{
  public class Bootstrapper : DefaultNancyBootstrapper
  {

    protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
    {
      base.ApplicationStartup(container, pipelines);

      RedisBasedSessions.Enable(pipelines);
    }
  }
}