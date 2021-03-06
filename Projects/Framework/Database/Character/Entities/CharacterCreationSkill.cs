﻿// Copyright (c) Arctium Emulation.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Lappa_ORM;

namespace Framework.Database.Character.Entities
{
    public class CharacterCreationSkill : Entity
    {
        [PrimaryKey]
        public byte Race    { get; set; }
        public byte Class   { get; set; }
        public int SkillId  { get; set; }
    }
}
