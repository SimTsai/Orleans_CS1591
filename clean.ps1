dotnet clean Orleans_CS1591.sln
Get-ChildItem .\ -include bin,obj -Recurse | ForEach-Object ($_) { Remove-Item $_.fullname -Force -Recurse }