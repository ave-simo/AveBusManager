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


## ⚙️ Architettura

Il progetto usa un’architettura event-driven, in cui i componenti non comunicano tramite chiamate dirette ma reagiscono a eventi generati quando qualcosa accade (es. dati letti dal bus). Questo riduce l’accoppiamento e rende il flusso più chiaro e controllabile.

È applicato l’Observer pattern: AveBusController espone eventi (onBusEvent) e non conosce chi li consumerà; la GUI si registra come osservatore tramite GuiEventHandler, che traduce gli eventi in aggiornamenti grafici.

GuiEventHandler funge anche da adattatore di threading: gli eventi provenienti dal thread di lettura vengono sincronizzati sul thread UI tramite Invoke / BeginInvoke.
