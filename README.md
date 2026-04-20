# File Integrity Checker (C#)

Un utilitaire console léger en C# conçu pour vérifier l'intégrité de vos fichiers locaux en générant et en comparant des hashs SHA-256.

## 🛡️ À propos du projet

Ce projet a été développé pour comprendre les fondements de l'intégrité des données en cybersécurité. L'application permet de détecter si un fichier a été modifié, corrompu ou altéré en comparant son empreinte numérique (hash) actuelle avec une référence connue.

C'est un excellent outil pour vérifier rapidement l'authenticité d'un fichier après un téléchargement ou pour surveiller l'intégrité de fichiers sensibles.

## 🚀 Fonctionnalités

- **Génération SHA-256 :** Calcule l'empreinte numérique unique de n'importe quel fichier.
- **Interface intuitive :** Glisser-déposez simplement votre fichier dans la console pour obtenir son hash.
- **Mode comparaison :** Vérification immédiate de l'intégrité avec un hash de référence.
- **Retour visuel :** Utilisation de codes couleurs pour identifier rapidement si le fichier est sain ou altéré.

## 🛠️ Installation

1. Assurez-vous d'avoir le [SDK .NET](https://dotnet.microsoft.com/download) installé sur votre machine et la dernière version de Git : https://git-scm.com/install/windows pour connecter Visual Studio Code à Github

2. Clonez le dépôt :
   ```bash
   git clone https://github.com/Maxime288/File-Integrity-Checker-CSharp.git
   ```
3. Accédez au dossier du projet :
   ```bash
   cd File-Integrity-Checker-CSharp
   ```

## 💻 Utilisation

Pour lancer l'application, exécutez la commande suivante dans votre terminal :

```bash
dotnet run
```

Ensuite, suivez les instructions à l'écran :

1. Glissez-déposez le fichier à analyser.
2. Copiez le hash affiché.
3. Pour vérifier l'intégrité plus tard, relancez l'outil, glissez le même fichier, et collez le hash de référence quand on vous le demande.

## 📷 Aperçu

<img width="1538" height="482" alt="image" src="https://github.com/user-attachments/assets/b149cdef-b38e-4d6f-8adb-66dca67a8558" />


## ⚠️ Disclaimer

Cet outil est fourni à des fins éducatives et de développement personnel. Bien qu'il utilise des algorithmes cryptographiques standards (SHA-256), il ne remplace pas une solution de sécurité professionnelle ou un antivirus complet.
