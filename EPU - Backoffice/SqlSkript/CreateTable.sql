USE [Backoffice]
GO
/****** Object:  Table [dbo].[Kontakt]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kontakt](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Vorname] [nvarchar](max) NOT NULL,
	[Nachname] [nvarchar](max) NOT NULL,
	[Firma] [nvarchar](max) NULL,
 CONSTRAINT [PK_Kontakt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projekt]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projekt](
	[ID] [int] NOT NULL,
	[Arbeitszeit] [float] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Projekt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buchungskategorie]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buchungskategorie](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Buchungskategorie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Angebot]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Angebot](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Summe] [money] NOT NULL,
	[Anfangsdatum] [datetime] NOT NULL,
	[Enddatum] [datetime] NOT NULL,
	[Chance] [numeric](1, 1) NOT NULL,
	[ProjektID] [int] NOT NULL,
	[KundeID] [int] NOT NULL,
 CONSTRAINT [PK_Angebot] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eingangsrechnung]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eingangsrechnung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KontaktID] [int] NOT NULL,
	[RechnungID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Eingangsrechnung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kunde]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kunde](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KontaktID] [int] NOT NULL,
 CONSTRAINT [PK_Kunde] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ausgangsrechnung]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ausgangsrechnung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AngebotID] [int] NOT NULL,
	[RechnungID] [int] NOT NULL,
 CONSTRAINT [PK_Ausgangsrechnung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buchung]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buchung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Betrag] [money] NOT NULL,
	[BuchungskategorieID] [int] NOT NULL,
	[Datum] [datetime] NOT NULL,
 CONSTRAINT [PK_Buchung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuchungRechnung]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuchungRechnung](
	[RechnungID] [int] NOT NULL,
	[BuchungID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rechnung]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rechnung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Betrag] [money] NOT NULL,
 CONSTRAINT [PK_Rechnung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rechnungszeile]    Script Date: 03/03/2012 19:44:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rechnungszeile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AusgangsrechnungID] [int] NOT NULL,
 CONSTRAINT [PK_Rechnungszeile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Angebot_Kunde]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Angebot]  WITH CHECK ADD  CONSTRAINT [FK_Angebot_Kunde] FOREIGN KEY([KundeID])
REFERENCES [dbo].[Kunde] ([ID])
GO
ALTER TABLE [dbo].[Angebot] CHECK CONSTRAINT [FK_Angebot_Kunde]
GO
/****** Object:  ForeignKey [FK_Angebot_Projekt]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Angebot]  WITH CHECK ADD  CONSTRAINT [FK_Angebot_Projekt] FOREIGN KEY([ProjektID])
REFERENCES [dbo].[Projekt] ([ID])
GO
ALTER TABLE [dbo].[Angebot] CHECK CONSTRAINT [FK_Angebot_Projekt]
GO
/****** Object:  ForeignKey [FK_Eingangsrechnung_Kontakt]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Eingangsrechnung]  WITH CHECK ADD  CONSTRAINT [FK_Eingangsrechnung_Kontakt] FOREIGN KEY([KontaktID])
REFERENCES [dbo].[Kontakt] ([ID])
GO
ALTER TABLE [dbo].[Eingangsrechnung] CHECK CONSTRAINT [FK_Eingangsrechnung_Kontakt]
GO
/****** Object:  ForeignKey [FK_Kunde_Kontakt]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Kunde]  WITH CHECK ADD  CONSTRAINT [FK_Kunde_Kontakt] FOREIGN KEY([KontaktID])
REFERENCES [dbo].[Kontakt] ([ID])
GO
ALTER TABLE [dbo].[Kunde] CHECK CONSTRAINT [FK_Kunde_Kontakt]
GO
/****** Object:  ForeignKey [FK_Ausgangsrechnung_Angebot]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Ausgangsrechnung]  WITH CHECK ADD  CONSTRAINT [FK_Ausgangsrechnung_Angebot] FOREIGN KEY([AngebotID])
REFERENCES [dbo].[Angebot] ([ID])
GO
ALTER TABLE [dbo].[Ausgangsrechnung] CHECK CONSTRAINT [FK_Ausgangsrechnung_Angebot]
GO
/****** Object:  ForeignKey [FK_Ausgangsrechnung_Rechnung]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Ausgangsrechnung]  WITH CHECK ADD  CONSTRAINT [FK_Ausgangsrechnung_Rechnung] FOREIGN KEY([RechnungID])
REFERENCES [dbo].[Rechnung] ([ID])
GO
ALTER TABLE [dbo].[Ausgangsrechnung] CHECK CONSTRAINT [FK_Ausgangsrechnung_Rechnung]
GO
/****** Object:  ForeignKey [FK_Buchung_Buchungskategorie]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Buchung]  WITH CHECK ADD  CONSTRAINT [FK_Buchung_Buchungskategorie] FOREIGN KEY([BuchungskategorieID])
REFERENCES [dbo].[Buchungskategorie] ([ID])
GO
ALTER TABLE [dbo].[Buchung] CHECK CONSTRAINT [FK_Buchung_Buchungskategorie]
GO
/****** Object:  ForeignKey [FK_BuchungRechnung_Buchung]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[BuchungRechnung]  WITH CHECK ADD  CONSTRAINT [FK_BuchungRechnung_Buchung] FOREIGN KEY([BuchungID])
REFERENCES [dbo].[Buchung] ([ID])
GO
ALTER TABLE [dbo].[BuchungRechnung] CHECK CONSTRAINT [FK_BuchungRechnung_Buchung]
GO
/****** Object:  ForeignKey [FK_BuchungRechnung_Rechnung]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[BuchungRechnung]  WITH CHECK ADD  CONSTRAINT [FK_BuchungRechnung_Rechnung] FOREIGN KEY([RechnungID])
REFERENCES [dbo].[Rechnung] ([ID])
GO
ALTER TABLE [dbo].[BuchungRechnung] CHECK CONSTRAINT [FK_BuchungRechnung_Rechnung]
GO
/****** Object:  ForeignKey [FK_Rechnung_Eingangsrechnung]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Rechnung]  WITH CHECK ADD  CONSTRAINT [FK_Rechnung_Eingangsrechnung] FOREIGN KEY([ID])
REFERENCES [dbo].[Eingangsrechnung] ([ID])
GO
ALTER TABLE [dbo].[Rechnung] CHECK CONSTRAINT [FK_Rechnung_Eingangsrechnung]
GO
/****** Object:  ForeignKey [FK_Rechnungszeile_Ausgangsrechnung]    Script Date: 03/03/2012 19:44:33 ******/
ALTER TABLE [dbo].[Rechnungszeile]  WITH CHECK ADD  CONSTRAINT [FK_Rechnungszeile_Ausgangsrechnung] FOREIGN KEY([AusgangsrechnungID])
REFERENCES [dbo].[Ausgangsrechnung] ([ID])
GO
ALTER TABLE [dbo].[Rechnungszeile] CHECK CONSTRAINT [FK_Rechnungszeile_Ausgangsrechnung]
GO
