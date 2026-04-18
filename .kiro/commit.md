# Como Realizar Commits

## Regras
- Título e descrição sempre em **letras minúsculas**.
- Usar o verbo **"adiciona"** (não "adicionar").
- Seguir o padrão **Conventional Commits** (ex: `chore:`, `feat:`, `fix:`).

## Exemplo

```bash
git commit -m "chore: adiciona configurações do kiro" -m "descrição detalhada do que foi feito"
```

## Observações
- Sempre fazer staging apenas dos arquivos relevantes ao commit (`git add <pasta ou arquivo>`), evitando `git add .`.
- O push fica por conta do usuário.
