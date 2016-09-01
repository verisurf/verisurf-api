
#ifndef CONNECTIONERROR_H_INCLUDED
#define CONNECTIONERROR_H_INCLUDED

#include "../JuceLibraryCode/JuceHeader.h"

class ConnectionError : public Component
{
public:
	ConnectionError()
	{
	}

    void paint (Graphics& g) override
    {
		g.setColour(Colours::white);
		g.setFont(64.0f);
		g.drawText("SDK LIVE REPORT", Rectangle<int>(0, 25, 750, 100), Justification::centredTop, true);
		g.setFont(32.0f);
		g.drawText("VERISURF CONNECTION COULD NOT BE ESTABLISHED", Rectangle<int>(0, 120, 750, 100), Justification::centredTop, true);
		g.drawText("PLEASE VERIFY THE TCP API IS ENABLED", Rectangle<int>(0, 160, 750, 100), Justification::centredTop, true);
    }

private:
    JUCE_DECLARE_NON_COPYABLE_WITH_LEAK_DETECTOR (ConnectionError)
};

#endif  // CONNECTIONERROR_H_INCLUDED
