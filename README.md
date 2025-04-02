# Playground

Beispiel Projekt für den Aufbau eines neuen ASP.NET Service mit .NET 8.0

## Features

1. Leeres ASP.NET Projekt erstellen ab Template "ASP.NET Core Empty"
2. Integration von Logging mittels "Serilog"
3. Multi-Mandanten-Unterstützung implementieren mittels [CMI.Infrastructure.MultiTenancy](https://github.com/CMInformatik/cmi-infrastructure-multi-tenancy)
   3.1 Folgende Schritte aus dem README.md bei der Integration durchführen:
   3.1.1. Applikationsspezifische Mandanten-Klasse definieren
   3.1.2. Tenants in der Konfiguration definieren und optional nachbereiten
   3.1.3. Die Multi-Tenant-Middleware im Startup-Prozess einfügen.
