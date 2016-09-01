
#include "../JuceLibraryCode/JuceHeader.h"
#include "MainComponent.h"
#include "CustomLook.h"

class CApplication : public JUCEApplication
{
	public:
		CApplication()
		{
			LookAndFeel::setDefaultLookAndFeel (&customLook);
		}

		const String getApplicationName() override
		{
			return ProjectInfo::projectName;
		}
		const String getApplicationVersion() override
		{
			return ProjectInfo::versionString;
		}
		bool moreThanOneInstanceAllowed() override
		{
			return true;
		}

		void initialise (const String&) override
		{
			mainWindow = new MainWindow (getApplicationName());
		}

		void shutdown() override
		{
			mainWindow = nullptr; // (deletes our window)
		}

		void systemRequestedQuit() override
		{
			quit();
		}

		void anotherInstanceStarted (const String&) override
		{
		}

		class MainWindow : public DocumentWindow
		{
			public:
				MainWindow (String name)  : DocumentWindow (name,
							Colours::lightgrey,
							DocumentWindow::minimiseButton | DocumentWindow::closeButton)
				{
					setUsingNativeTitleBar (true);
					setContentOwned (new MainContentComponent(), true);

					centreWithSize (getWidth(), getHeight());
					setVisible (true);
				}

				void closeButtonPressed() override
				{
					JUCEApplication::getInstance()->systemRequestedQuit();
				}
			private:
				JUCE_DECLARE_NON_COPYABLE_WITH_LEAK_DETECTOR (MainWindow)
		};

	private:
		CustomLook customLook;
		ScopedPointer<MainWindow> mainWindow;
};

START_JUCE_APPLICATION (CApplication)
