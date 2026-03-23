 # 🏰 **Plateformer 2D à Défilement Infini**
*Un jeu de plateforme où votre objectif est d’aller le plus loin possible en évitant les chutes !*

---

## 🎯 **Concept du Jeu**
Incarniez un **chevalier** dans un monde 2D généré procéduralement. Votre mission :
- **Survivre** en sautant de plateforme en plateforme.
- **Atteindre le meilleur score** en accumulant des points :
  - **+1 point** à chaque passage sur une plateforme.
  - **+1 point bonus** si vous récupérez une pièce.
- **Seule commande disponible** : **Sauter** (n’importe quelle autre touche sauf `[Échap]` pour la pause).

Les plateformes apparaissent à **hauteurs variables** mais avec un **espacement constant**, créant un défi progressif.

---

## 🎮 **Mécaniques de Jeu**

### 📹 **Caméra**
- **Fixe** : La caméra ne bouge pas. Le joueur et les plateformes défilent vers elle, créant une illusion de mouvement infini.

### ⌨️ **Commandes**
| Action          | Touche(s)                          |
|-----------------|------------------------------------|
| Sauter          | `**n’importe quelle touche** (sauf `[Échap]`) |
| Mettre en pause  | `[Échap]`                          |

- **Double saut** : Le joueur peut sauter une deuxième fois en l’air.

### 👾 **Personnage**
- **Animations** :
  - *Idle* (immobile sur une plateforme),
  - *Saut*,
  - *Course* (lors du défilement).
- **Mort** : Si le personnage tombe en dehors de l’écran.

### 📝 **Fonctionnalités Clés**
- **Génération procédurale** : Les plateformes sont créées dynamiquement (seule la hauteur varie).
- **Défilement latéral** : Les plateformes avancent vers le joueur et se détruisent lorsqu’elles sortent de la caméra.
- **Système de score** :
  - Affiché en temps réel.
  - Incrémenté à chaque passage sur une plateforme ou récupération de pièce.
- **Pièces à collectionner** : Augmentent le score et ajoutent un challenge supplémentaire.
- **Double Saut** : Permet au joueur de faire de plus grands sauts.
- **Plateformes de tailles variées** : Pour diversifier le gameplay.
- **Menu principal** :
  - Options : *Jouer* / *Quitter*.
  - Interface minimaliste avec affichage du score.

---

## 🎵 **Ambiance Sonore**
- **Musiques de fond** : Pour une immersion totale.
- **Effets sonores** :
  - Saut,
  - Récupération de pièce.

---

## 🔥 **Bonus Implémentés**
✅ **Deux scènes** :
   - Menu principal,
   - Niveau de jeu.
   
✅ **Système de pause** : Accessible via `[Échap]`.

✅ **Effets visuels et sonores** pour une expérience plus immersive.

✅ **Double Saut** pour atteindre des plateformes plus hautes.

✅ **Variété de plateformes** : hauteurs aléatoires.

---

## 💻 **Comment Jouer ?**

### **Prérequis**
- Un PC sous **Windows** (build fournie).
- Aucun autre logiciel requis.

### **Installation**
1. Téléchargez le projet et **décompressez** le fichier ZIP.
2. Accédez au dossier **`BuildGame`**.
3. Lancez **`SecondGame.exe`** (double-cliquez).
4. **Le jeu démarre automatiquement** !

---

## 🛠 **Technologies Utilisées**
- **Moteur** : Unity (C#).
- **Outils** :
  - Animations 2D,
  - Génération procédurale,
  - Gestion des collisions et physique 2D.

---

## 📢 **Remerciements**
Merci d’avoir testé mon jeu ! N’hésitez pas à me faire part de vos retours ou suggestions pour l’améliorer.

---
*© Lou Lefebvre – 2026*
