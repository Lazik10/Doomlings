/*
Post-Deployment Script Template                            
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.        
 Use SQLCMD syntax to include a file in the post-deployment script.            
 Example:      :r .\myfile.sql                                
 Use SQLCMD syntax to reference a variable in the post-deployment script.        
 Example:      :setvar TableName MyTable                            
               SELECT * FROM [$(TableName)]                    
--------------------------------------------------------------------------------------
*/

-- Birth Cards - empty
-- Gene Pool Cards - empty
-- Player Aid Cards - empty

-- Age Cards
INSERT INTO [jointables].[AgeCardIcon] (AgeCardId, IconId)
VALUES
    (48, 32),       -- Badlands
    (49, 32),       -- Impact Event
    (50, 64),       -- Ozmorian WindsEyes Open from Behind the Stars
    (51, 64),       -- Eyes Open from Behind the Stars
    (52, 128),      -- Age of Metadata
    (53, 128);      -- Bieongineered Plague


-- Trait Cards
INSERT INTO [jointables].[TraitCardIcon] (TraitCardId, IconId)
VALUES
    (72, 1),        -- Echolocation
    (73, 1),        -- Immunity
    (73, 4),        -- Immunity
    (74, 1),        -- Tiny
    (74, 4),        -- Tiny
    (75, 8),        -- Automimicry
    (77, 16),       -- Chromatophores
    (78, 8),        -- Cold Blood
    (79, 8),        -- Costly Signaling
    (80, 4),        -- Egg Clusters
    (81, 8),        -- Flight
    (83, 8),        -- Indescent Scales
    (85, 8),        -- Painted Shell
    (88, 8),        -- Selective Memory
    (90, 8),        -- Sweat
    (91, 8),        -- Tentacles
    (92, 8),        -- Scutes
    (93, 8),        -- Tube Feet
    (94, 1),        -- Heroic
    (95, 1),        -- Pack Behaviour
    (95, 4),        -- Pack Behaviour
    (96, 1),        -- Symbiosis
    (96, 4),        -- Symbiosis
    (99, 4),        -- Branches
    (102, 4),       -- Fortunate
    (104, 4),       -- Overgrowth
    (105, 8),       -- Photosynthesis
    (106, 4),       -- Pollination
    (107, 8),       -- Propagation
    (108, 4),       -- Random Fertilization
    (109, 8),       -- Self-Replicatig
    (110, 4),       -- Swarm
    (111, 8),       -- Tiny Little Melons
    (112, 8),       -- Trunk
    (114, 8),       -- Beauty
    (115, 1),       -- Denial
    (116, 1),       -- Faith
    (117, 1),       -- Optimistic Nihilism
    (118, 4),       -- Altruistic
    (119, 8),       -- Boredom
    (122, 8),       -- Doting
    (123, 2),       -- Eloquance
    (126, 4),       -- Gratitude
    (127, 8),       -- Introspective
    (129, 16),      -- Late
    (130, 4),       -- Mindful
    (133, 2),       -- Prepper
    (135, 16),      -- Self-Awareness
    (136, 8),       -- The Third Eye
    (137, 8),       -- Bones
    (138, 1),       -- Camouflage
    (138, 4),       -- Camouflage
    (139, 1),       -- Vampirism
    (140, 1),       -- Viral
    (140, 2),       -- Viral
    (140, 4),       -- Viral
    (143, 8),       -- Clever
    (144, 8),       -- Directly Register
    (147, 8),       -- Impatience
    (148, 8),       -- Inventive
    (149, 8),       -- Memory
    (151, 8),       -- Nosy
    (152, 16),      -- Parasitic
    (153, 8),       -- Persuasive
    (154, 8),       -- Poisonous
    (155, 8),       -- Selfish
    (156, 2),       -- Sneaky
    (156, 16),      -- Sneaky
    (157, 4),       -- Sticky Secretions
    (160, 8),       -- Telekinetic
    (161, 8),       -- Venomous
    (162, 8),       -- Juicy
    (163, 1),       -- Apex Predator
    (163, 4),       -- Apex Predator
    (164, 1),       -- Hyper-Inetelligence
    (164, 2),       -- Hyper-Inetelligence
    (165, 1),       -- Sentience
    (165, 2),       -- Sentience
    (165, 4),       -- Sentience
    (167, 8),       -- Bad
    (168, 8),       -- Brave
    (173, 4),       -- Heat Vision
    (174, 8),       -- Hot Temper
    (175, 4),       -- Kidney
    (177, 8),       -- Reckless
    (180, 8),       -- Territorial
    (181, 8),       -- Voracious
    (183, 8),       -- Pride
    (185, 1),       -- Motley
    (192, 2),       -- Free Will
    (193, 4),       -- Tetrachromatic
    (194, 8),       -- Elongated Neck
    (194, 32),      -- Elongated Neck
    (195, 32),      -- Pterosaur Wings
    (195, 8),       -- Pterosaur Wings
    (196, 32),      -- Terror Beak
    (197, 32),      -- Bony Plates
    (197, 8),       -- Bony Plates
    (198, 32),      -- Ceratopsian Horns
    (199, 32),      -- Fronds
    (200, 32),      -- Thagomizer
    (200, 8),       -- Thagomizer
    (201, 32),      -- Cranial Crest
    (201, 4),       -- Cranial Crest
    (202, 32),      -- Dermal Armor
    (202, 8),       -- Dermal Armor
    (203, 32),      -- Pycnofibers
    (203, 8),       -- Pycnofibers
    (204, 32),      -- Egg Predation
    (204, 8),       -- Egg Predation
    (205, 32),      -- Protofeathers
    (205, 8),       -- Protofeathers
    (206, 32),      -- Talons
    (207, 32),      -- Carnosaur Jaw
    (207, 1),       -- Carnosaur Jaw
    (208, 32),      -- Serrated Teeth
    (208, 4),       -- Serrated Teeth
    (209, 32),      -- Tiny Arms
    (209, 4),       -- Tiny Arms
    (210, 1),       -- Legendary
    (210, 64),      -- Legendary
    (211, 64),      -- Diaphanous Wings
    (212, 64),      -- Icy
    (213, 64),      -- Righteous
    (213, 16),      -- Righteous
    (214, 64),      -- Elven Ears
    (214, 4),       -- Elven Ears
    (215, 64),      -- Fey
    (216, 64),      -- Orcish Tusks
    (216, 8),       -- Orcish Tusks
    (217, 64),      -- Destined
    (218, 64),      -- Effigial
    (218, 16),      -- Effigial
    (219, 64),      -- Rainbow Horn
    (219, 2),       -- Rainbow Horn
    (220, 64),      -- Necromantic
    (220, 16),      -- Necromantic
    (221, 64),      -- Witchy
    (221, 16),      -- Witchy
    (222, 64),      -- Zombified
    (222, 16),      -- Zombified
    (223, 64),      -- Ancient
    (223, 8),       -- Ancient
    (224, 64),      -- Dragon Heart
    (224, 4),       -- Dragon Heart
    (225, 64),      -- Gelatinous
    (225, 8),       -- Gelatinous
    (226, 64),      -- Mighty
    (226, 8),       -- Mighty
    (227, 128),     -- Cybernetic
    (228, 128),     -- Mecha
    (228, 8),       -- Mecha
    (229, 128),     -- Neural Link
    (229, 8),       -- Neural Link
    (230, 128),     -- Lyonization
    (231, 128),     -- Nano
    (231, 4),       -- Nano
    (232, 128),     -- Transgenic Modification
    (233, 128),     -- Ruggedized
    (233, 1),       -- Ruggedized
    (234, 128),     -- Binary
    (234, 8),       -- Binary
    (235, 128),     -- GMO
    (235, 4),       -- GMO
    (236, 128),     -- Grey Hat
    (236, 8),       -- Grey Hat
    (237, 128),     -- Electromagnetic
    (237, 8),       -- Electromagnetic
    (238, 128),     -- Hypermyelination
    (238, 4),       -- Hypermyelination
    (239, 128),     -- Subdermal Plating
    (239, 16),      -- Subdermal Plating
    (240, 128),     -- Bionic Arm
    (240, 4),       -- Bionic Arm
    (241, 128),     -- Bone Reinforcement
    (242, 128),     -- Phreakish Eyes
    (242, 8);       -- Phreakish Eyes