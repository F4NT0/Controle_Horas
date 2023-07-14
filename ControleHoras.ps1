# Variáveis
$EmojiIcon = [System.Convert]::toInt32("2705",16)
$conteudo = Get-Content -Path "ascii.txt"

Write-Host ""

# Lendo as informações do arquivo ASCII
foreach ($linha in $conteudo) {
    Write-Host $linha
}

# Apresentando mensagem de boas vindas
Write-Host ""
Write-Host -ForegroundColor Green ([System.Char]::ConvertFromUtf32($EmojiIcon)) -NoNewline
Write-Host " INICIANDO PROGRAMA DE CONTROLE DE HORAS"
Write-Host ""

# Executando o programa
cd C:\Users\Gabriel_Stundner\source\repos\GITHUB\Controle_Horas
cd ControleHoras
powershell -noexit -command "dotnet run"