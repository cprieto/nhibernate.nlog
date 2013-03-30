# NHibernate logging adapter for NLog 
With this adapter you can send NHibernate log messages directly to NLog, without any non-needed abstraction (like Common.Logging).

The NuGet package add the needed app.config (or web.config) appSetting to enable NHibernate logging with NLog, every NHibernate logger starts with the NHibernate name. Just if you are curious, this is what we add to your app configuration file:
```xml
<appSettings>
    <add key="nhibernate-logger" value="NHibernate.NLogLoggerFactory, NHibernate.NLog"/>
</appSettings>
```
For example, to send the NHibernate issued SQL to the trace NLog target first enable SQL messages in NHibernate (this is done simply adding the property show_sql in your NHibernate configuration):
```xml
<property name="show_sql">true</property>
```
Then, your NLog configuration should look like this:
```xml
<targets>
  <target name="trace" type="Trace" />
</targets>
<rules>
  <logger name="NHibernate.SQL" writeTo="trace" />
</rules>
```
Just remember that by default in NHibernate if you enable show_sql in your configuration it will send the issued SQL directly to your trace listener, in a test runner like ReSharper Test Runner or TestDriven.Net that means the result output window, yeah, to see the issued SQL you don't need to do anything by default, just enable it in the NHibernate config (and I don't know why that's a hidden secret).