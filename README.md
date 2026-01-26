# AveBusManager

Applicazione **WinForms (.NET Framework 4.7.2)** per la gestione e il monitoraggio di un bus seriale (AveBus), con interfaccia grafica e modalità CLI.

## ✨ Funzionalità principali

* Connessione a porta **COM** configurabile
* Controllo **Luci 1 e Luci 2** (ON / OFF / Toggle)
* Indicatori di **stato luci** in tempo reale
* Lettura asincrona del bus
* Log eventi
* Aggiornamenti thread-safe della GUI

## 🧱 Struttura progetto

* `Controllers/` – Logica di comunicazione bus
* `Handlers/` – Gestione eventi e aggiornamenti GUI
* `Guis/` – Interfaccia grafica
* `CLI.cs` – Modalità riga di comando

## ▶️ Avvio

* **GUI**: avvio standard dell’eseguibile
* **CLI**: avviare con parametro `--cli`
