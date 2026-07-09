# SiriusBot AI Platform

## Descripción

SiriusBot AI Platform es una plataforma inteligente orientada a la administración de propiedades turísticas mediante automatización, inteligencia artificial y asistentes conversacionales.

El sistema utiliza un enfoque modular donde los canales de comunicación son independientes de la lógica empresarial.

## Objetivo MVP

Implementar un asistente inteligente capaz de:

- Gestionar propiedades.
- Registrar gastos.
- Procesar documentos.
- Automatizar tareas administrativas.
- Interactuar mediante canales conversacionales.

## Arquitectura

El proyecto está basado en Clean Architecture:
src

├── SiriusBot.API
│ Capa de presentación y APIs

├── SiriusBot.Application
│ Casos de uso y lógica aplicación

├── SiriusBot.Domain
│ Reglas del negocio

└── SiriusBot.Infrastructure
Servicios externos y persistencia


## Tecnologías

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Telegram Bot API
- n8n
- Inteligencia Artificial

## Estado del proyecto

MVP en desarrollo.

## Roadmap

- [x] Arquitectura base
- [ ] Integración Telegram
- [ ] Gestión inteligente de gastos
- [ ] Integración IA
- [ ] Automatizaciones n8n