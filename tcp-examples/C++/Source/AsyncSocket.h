
#ifndef ASYNCSOCKET_H_INCLUDED
#define ASYNCSOCKET_H_INCLUDED

#include "../JuceLibraryCode/JuceHeader.h"

class AsyncSocket : private Thread
{
	public:
		AsyncSocket() : Thread ("async")
		{
			deviceData.resize (10, "0");
			streamingSocket = new StreamingSocket();
			startThread();
		}
		~AsyncSocket()
		{
			stopThread (10000);
		}

		bool Connected()
		{
			if (streamingSocket->isConnected())
				return true;

			streamingSocket->connect ("localhost", 33666);

			if (streamingSocket->isConnected())
				return true;
			else
				return false;
		}

		bool IsDeviceSet()
		{
			return selectedDevice.length() > 0 ? true : false;
		}

		void SetDevice (String in)
		{
			selectedDevice = in;
		}

		String GetSelectedDevice()
		{
			return selectedDevice;
		}

		std::vector<String> GetDeviceData()
		{
			return deviceData;
		}

		std::vector<String> GetDeviceList()
		{
			return deviceList;
		}

	private:
		void RequestDeviceInfo()
		{
			String s ("<device_info id='" + selectedDevice + "' />\n");
			streamingSocket->write (s.getCharPointer(), s.length());
		}

		void RequestStartBuild()
		{
			inBuildMode = true;
			String s ("<build />\n");
			streamingSocket->write (s.getCharPointer(), s.length());
		}

		void RequestDeviceList()
		{
			devicesRequested = true;
			String s ("<device_list />\n");
			streamingSocket->write (s.getCharPointer(), s.length());
		}

		void ParseResponse()
		{
			if (streamingSocket->waitUntilReady (true, 500) != 1)
				return;

			int size;
			char buf[2048];
			size = streamingSocket->read (buf, 2048, false);
			if (size < 0)
				return;

			std::string response (buf);
			response.substr (0, size);
			if (response.find_last_of ('>') != std::string::npos)
			{
				response = response.substr (0, response.find_last_of ('>') + 1);

				juce::XmlDocument document (response);

				ScopedPointer<XmlElement> root;
				XmlElement* device_info;
				XmlElement* device_list;

				root = document.getDocumentElement();
				if (root != nullptr)
				{
					device_list = root->getChildByName ("device_list");
					if (device_list != nullptr)
					{
						for (XmlElement* childElement = device_list->getFirstChildElement(); childElement != nullptr; childElement = childElement->getNextElement())
						{
							if (childElement->hasAttribute ("name"))
								deviceList.push_back (childElement->getStringAttribute ("name"));
						}
					}

					device_info = root->getChildByName ("device_info");
					if (device_info != nullptr)
					{
						if (device_info->hasAttribute ("X"))
							deviceData[0] = device_info->getStringAttribute ("X");
						if (device_info->hasAttribute ("PX"))
							deviceData[1] = device_info->getStringAttribute ("PX");
						if (device_info->hasAttribute ("DX"))
							deviceData[2] = device_info->getStringAttribute ("DX");
						if (device_info->hasAttribute ("Y"))
							deviceData[3] = device_info->getStringAttribute ("Y");
						if (device_info->hasAttribute ("PY"))
							deviceData[4] = device_info->getStringAttribute ("PY");
						if (device_info->hasAttribute ("DY"))
							deviceData[5] = device_info->getStringAttribute ("DY");
						if (device_info->hasAttribute ("Z"))
							deviceData[6] = device_info->getStringAttribute ("Z");
						if (device_info->hasAttribute ("PZ"))
							deviceData[7] = device_info->getStringAttribute ("PZ");
						if (device_info->hasAttribute ("DZ"))
							deviceData[8] = device_info->getStringAttribute ("DZ");
						if (device_info->hasAttribute ("D3"))
							deviceData[9] = device_info->getStringAttribute ("D3");
					}
				}
			}
		}

		void run() override
		{
			while (!threadShouldExit())
			{
				wait (500);
				if (Connected())
				{
					ParseResponse();

					if (devicesRequested == false)
						RequestDeviceList();
					else if (IsDeviceSet() && inBuildMode == false)
						RequestStartBuild();
					else if (IsDeviceSet())
						RequestDeviceInfo();
				}
			}
		}

		bool inBuildMode = false;
		bool devicesRequested = false;

		String selectedDevice;
		std::vector<String> deviceList;
		std::vector<String> deviceData;
		ScopedPointer<StreamingSocket> streamingSocket;
};

#endif  // ASYNCSOCKET_H_INCLUDED
