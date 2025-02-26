$module = 'DiffCode.CommonEntities.Sources'
$version = '1.0.2'


dotnet restore
dotnet pack -c Release -o bin\Release\publish
dotnet nuget push bin\Release\publish\$module.$version.nupkg --source https://proget.gmel.pro:8625/nuget/NuGetPrivate/ --api-key $ENV:ProGetApiKey --skip-duplicate