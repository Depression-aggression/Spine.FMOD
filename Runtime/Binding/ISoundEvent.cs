﻿// Copyright © 2023 Nikolay Melnikov. All rights reserved.
// SPDX-License-Identifier: Apache-2.0

using UnityEngine;

namespace Depra.Spine.FMOD.Runtime.Binding
{
	internal interface ISoundEvent
	{
		string Key { get; }

		void Play(string key, Transform sourcePoint = null);
	}
}