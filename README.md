View live system logs as an OWIN dashboard. The idea is to make it super-simple to 
watch application logs in realtime and actually get something useful rather than 
trawling through long log files.

See sample project for what consuming code might look like.

Currently only (barely) supports `Trace` classes from the .NET framework itself, 
but in the future may be expanded to allow other logging libraries to be plugged in.

Published as a nuget package: https://www.nuget.org/packages/OwinLoggingDashboard/
