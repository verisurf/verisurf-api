
#ifndef MAINCOMPONENT_H_INCLUDED
#define MAINCOMPONENT_H_INCLUDED

#include "../JuceLibraryCode/JuceHeader.h"
#include "AsyncSocket.h"
#include "DeviceSelector.h"
#include "ReportComponent.h"
#include "ConnectionError.h"

class MainContentComponent : public Component, public Timer
{
	public:
		MainContentComponent()
		{
			socket = new AsyncSocket();

			setSize (750, 563);
			startTimer (5000);

			imageComponent = new ImageComponent();
			imageComponent->setImage (ImageCache::getFromMemory (BinaryData::background_jpg, BinaryData::background_jpgSize));
			imageComponent->setBounds (getLocalBounds());
			addAndMakeVisible (imageComponent);

			mainButton = new TextButton();
			mainButton->setButtonText ("Connecting...");
			mainButton->setBounds (270, 200, 210, 34);
			addAndMakeVisible (mainButton);
		}

	private:
		void timerCallback() override
		{
			//connection error
			if (socket->Connected() == false)
			{
				stopTimer();
				mainButton->setVisible(false);
				connectionError = new ConnectionError();
				connectionError->setBounds(getLocalBounds());
				addAndMakeVisible(connectionError);
			}
			//device selection
			else if (socket->Connected() == true && socket->IsDeviceSet() == false)
			{
				if (initializedDeviceSelector == false)
				{
					initializedDeviceSelector = true;
					startTimer(500);
					mainButton->setVisible(false);
					deviceSelector = new DeviceSelector(socket);
					deviceSelector->setBounds (getLocalBounds());
					addAndMakeVisible(deviceSelector);
				}
			}
			//live report
			else
			{
				stopTimer();
				deviceSelector->setVisible (false);
				reportComponent = new ReportComponent(socket);
				reportComponent->setBounds (getLocalBounds());
				addAndMakeVisible (reportComponent);
			}
		}

		bool initializedDeviceSelector = false;

		ScopedPointer<AsyncSocket> socket;

		ScopedPointer<Label> loadingLabel;
		ScopedPointer<TextButton> mainButton;
		ScopedPointer<ImageComponent> imageComponent;
		ScopedPointer<DeviceSelector> deviceSelector;
		ScopedPointer<ReportComponent> reportComponent;
		ScopedPointer<ConnectionError> connectionError;
		JUCE_DECLARE_NON_COPYABLE_WITH_LEAK_DETECTOR (MainContentComponent)
};

#endif  // MAINCOMPONENT_H_INCLUDED
