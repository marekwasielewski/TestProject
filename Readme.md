<p align="center">
    <img src="http://sit.telemetria.eu:4063/job/TestProject/badge/icon"
         height="130">
</p>


PrÛba instalacji serwera jenkins na Windows 10
èrÛd≥a:
- http://www.danmusk.com/how-to-build-asp-net-applications-in-teamcity-with-msbuild-tools-2013-and-net-framework-4-5-sdk/
- http://www.frictionlesscode.com/have-continuous-integration-with-jenkins-in-30-mins/
-http://blog.couchbase.com/2016/january/continuous-deployment-with-jenkins-and-.net
1. Projekt 
	- naleøy stworzyÊ profil zapisany w /Projekt/Properies/PublishProfiles
	- profil: Site Name: testWeb -  posiada nazwÍ strony, ktÛra bÍdzie uøywana W SERWERZE DOCELOWYM
	- profil: Package location: /Publish/DeployPackage.zip
2. Utworzono Virtualnπ maszynÍ na VirtualBox  Windows 10 x64
3. Instalacja Microsofy Build tools 2015 do instalacji us≥ugi https://www.microsoft.com/en-us/download/details.aspx?id=48159
4. Instalacj GIT https://git-scm.com/download/win
5. Instalacja Jenkins 2.7.1 z msi
	- http://localhost:8080
	- admin 1234
	- po instlacji dodano wtyki: MS BUILD, NODEJS , GITHUB, BITBUCKET
	- jenkins przetrzymuje informacje o zadaniach w C:\Program Files (x86)\Jenkins\workspace
6. Instalacja SDK, øeby ms build mÛg≥ zbudowaÊ
	- wyczyta≥em øe 4.0 jest w ramach 4.6 http://stackoverflow.com/questions/35733040/how-to-install-net-4-framework-in-windows-10,ale dalej siÍnie kompuluje 
	- instalacja https://developer.microsoft.com/pl-PL/windows/downloads/windows-10-sdk wybrano 3 pozycje: Windows sdk, msi tools, .net sdk 4.6
7. Kompilacja projektu wraz z publish package
	- cmd z uprawnieniami ADMINISTRATORA
	- "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" "C:\Program Files (x86)\Jenkins\workspace\TestProject\test9510 API\test9510 API.sln" /p:DeployOnBuild=true;Configuration=Release;PublishProfile=testPusblish
	- utworzy packagae w C:\Publish\
8. Publikacja aplikacji do IIS
	- wymagane jest zainstalowany IIS
	- naleøy stworzyÊ stronÍ IIS o tytule z profilu aplikacji 
	- cmd z uprawbnieniami ADMINISTRATORA
	- wywo≥aÊ komendÍ "C:\Publish\DeployPackage.deploy.cmd" /Y ,ktÛra kopiuje aplikacjÍ w odpowiednie miejsce
	- strona http://localhost/Service1.svc dzia≥a
9. Konfiguracja Jenkins
	- 


