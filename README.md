Clean Architecture API

Ky është një projekt .NET Web API i ndërtuar duke ndjekur Clean Architecture. Projekti përfshin implementimin e dy pattern-eve:

Prototype Pattern (nga Creational Patterns) për të klonuar objektet.

	•	Implementuar në Product.cs në ApplicationCore/Entities/.
	•	Përdor Clone() për të klonuar objektet Product.

Adapter Pattern (nga Structural Patterns) për të përshtatur të dhënat në format JSON.

	•	Implementuar në JsonAdapter.cs në Infrastructure/Adapters/.
	•	Konverton listën e produkteve në format JSON.

Teknologjitë e Përdorura

    ✅ .NET 8 Web API 
    ✅ Clean Architecture 
    ✅ Dependency Injection 
    ✅ Prototype Pattern 
    ✅ Adapter Pattern 
    ✅ Swagger UI për dokumentacionin
