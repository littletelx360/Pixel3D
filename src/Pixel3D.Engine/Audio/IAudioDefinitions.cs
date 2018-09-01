﻿using Pixel3D.Audio;

namespace Pixel3D.Engine.Audio
{
	public interface IAudioDefinitions
	{
	    Cue GetCue(string name, object debugContext);
        SafeSoundEffect GetSound(Cue cue, int index);
	}
}