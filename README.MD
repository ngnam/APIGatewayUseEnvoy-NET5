## API Gateway with Envoy Solution .NET5

- Configure for HTTPS - Certificates

`
	dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\CoffeeWebAPI.pfx -p pa55w0rd!
	dotnet dev-certs https --trust
`
- Configure for HTTPS - User Secrets

`
	dotnet user-secrets set "Kertrel:Certificates:Development:Password" "pa55w0rd!"
`
- Add Docker Compose Setup multicontainer

https://docs.microsoft.com/en-us/visualstudio/containers/tutorial-multicontainer?view=vs-2019