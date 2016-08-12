|Operation|Status|
| --- | --- |
| **Build** | [![Build status](https://img.shields.io/jenkins/s/http/sit.telemetria.eu:4063/BuildTask.svg?maxAge=1)](http://10.20.0.6:4063/job/BuildTask/lastBuild/) |
| **API Tests**|  [![Tests](https://img.shields.io/jenkins/s/http/sit.telemetria.eu:4063/ApiTest.svg?maxAge=1)](http://docs.test9510.apiary.io)|
| **Unit Tests**|  [![Tests](https://img.shields.io/jenkins/t/http/sit.telemetria.eu:4063/UnitTest.svg)](http://10.20.0.6:4063/job/UnitTest/HTML_Report/)|
| **Tests Coverage**| [![Tests](https://img.shields.io/jenkins/c/http/sit.telemetria.eu:4063/UnitTest.svg)](http://10.20.0.6:4063/job/UnitTest/lastBuild/cobertura/)|

Próba instalacji serwera jenkins na Windows 10
Źródła:
- http://www.danmusk.com/how-to-build-asp-net-applications-in-teamcity-with-msbuild-tools-2013-and-net-framework-4-5-sdk/
- http://www.frictionlesscode.com/have-continuous-integration-with-jenkins-in-30-mins/
-http://blog.couchbase.com/2016/january/continuous-deployment-with-jenkins-and-.net
1. Projekt 
	- należy stworzyć profil zapisany w /Projekt/Properies/PublishProfiles
	- profil: Site Name: testWeb -  posiada nazwę strony, która będzie używana W SERWERZE DOCELOWYM
	- profil: Package location: /Publish/DeployPackage.zip
2. Utworzono Virtualną maszynę na VirtualBox  Windows 10 x64
3. Instalacja Microsofy Build tools 2015 do instalacji usługi https://www.microsoft.com/en-us/download/details.aspx?id=48159
4. Instalacj GIT https://git-scm.com/download/win
5. Instalacja Jenkins 2.7.1 z msi
	- http://localhost:8080
	- admin 1234
	- po instlacji dodano wtyki: MS BUILD, NODEJS , GITHUB, BITBUCKET
	- jenkins przetrzymuje informacje o zadaniach w C:\Program Files (x86)\Jenkins\workspace
6. Instalacja SDK, żeby ms build mógł zbudować
	- wyczytałem że 4.0 jest w ramach 4.6 http://stackoverflow.com/questions/35733040/how-to-install-net-4-framework-in-windows-10,ale dalej sięnie kompuluje 
	- instalacja https://developer.microsoft.com/pl-PL/windows/downloads/windows-10-sdk wybrano 3 pozycje: Windows sdk, msi tools, .net sdk 4.6
7. Kompilacja projektu wraz z publish package
	- cmd z uprawnieniami ADMINISTRATORA
	- "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" "C:\Program Files (x86)\Jenkins\workspace\TestProject\test9510 API\test9510 API.sln" /p:DeployOnBuild=true;Configuration=Release;PublishProfile=testPusblish
	- utworzy packagae w C:\Publish\
8. Publikacja aplikacji do IIS
	- wymagane jest zainstalowany IIS
	- należy stworzyć stronę IIS o tytule z profilu aplikacji 
	- cmd z uprawbnieniami ADMINISTRATORA
	- wywołać komendę "C:\Publish\DeployPackage.deploy.cmd" /Y ,która kopiuje aplikację w odpowiednie miejsce
	- strona http://localhost/Service1.svc działa
9. Konfiguracja Jenkins
	- 


                                                       dredd "C:\Program Files (x86)\Jenkins\workspace\ApiTestProject\APITest\apiary.apib" http://localhost/Service1.svc -r apiary -j apiaryApiKey:5189769b0ab564b6be22b509ed6a1121 -j apiaryApiName:test9510
