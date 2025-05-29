@echo off
echo Compilation et exécution du programme C#...

:: Recherche du compilateur C# dans Windows
set CSC_PATH=%windir%\Microsoft.NET\Framework\v4.0.30319\csc.exe

if exist "%CSC_PATH%" (
    echo Compilateur trouvé: %CSC_PATH%
    "%CSC_PATH%" /nologo /out:program.exe program.cs
    if exist program.exe (
        echo Exécution du programme:
        echo ----------------------
        program.exe
        echo ----------------------
    ) else (
        echo Erreur de compilation
    )
) else (
    echo Compilateur C# non trouvé. Vérifiez que .NET Framework est installé.
)

echo.
echo Appuyez sur une touche pour fermer cette fenêtre...
pause > nul 