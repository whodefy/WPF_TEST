   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      L HWpfSenderReceiver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfSenderReceiver.ViewWpfSenderReceiver.View 5      '   !WpfSenderReceiver.View.SenderView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      b ^GalaSoft.MvvmLight.Platform, Version=5.4.1.0, Culture=neutral, PublicKeyToken=5f873c45e98af8a1.command http://www.galasoft.ch/mvvmlight  5      0local$clr-namespace:WpfSenderReceiver.View  5        � DataContext  5      ��    Locator �� Source# [   �� Path$ SenderViewModel�.��5      � ���	#FFEEEBD9.+�5   
   �� $��Sender��6   $
��Left=�6!   $	��Top=�6<   $��	10,10,0,0q�6T   $��20(�6g   $
��Bold"�6u   �� 5   
   $��Name : ��6   $
��Left=�6"   $	��Top=�6=   $��	20,56,0,0q�6U   $��23��6h   $��66��6t   �� 5   
   $��RegNo : ��6   $
��Left=�6#   $	��Top=�6>   $��	20,84,0,0q�6V   $��23��6i   $��65��6u   �� 5   
   $��Age :��6   $
��Left=�6    $	��Top=�6;   $��
20,112,0,0q�6S   $��23��6g   $��66��6s   �� 5   
   $��BirthDate : ��6   $
��Left=�6'   $	��Top=�6B   $��20,140.649,0,0q�6Z   $��23��6r   �� 5   
   $��Center=�6   $��23��6/    �� TextWrapping$
 Wrap=�6;   $	��Top=�6h   $	��120��6�   $��0,56,0,0q�6�   ��6O   �� *	StrName+6�   �� 5   
   $��Center=�6   $��23��6/   $
 Wrap=�6;   $	��Top=�6i   $	��120��6�   $��0,84,0,0q�6�   ��6O   �� *
StrRegNo+6�   �� 5   
   $��Center=�6   $��23��6/   $
 Wrap=�6;   $	��Top=�6g   $	��120��6   $��	0,112,0,0q�6�   ��6O   �� *StrAge+6�   �� 5   
   $��Center=�6   $��23��6/   $
 Wrap=�6;   $	��Top=�6l   $	��120��6�   $��	0,141,0,0q�6�   ��6O   �� *StrBirthDay+6�   �� 5   
   $
��Send��6   $
��Left=�6    $��200,220,0,0q�6;   $	��Top=�6P   $��75��6h   .   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5         	EventName$ Click��6!   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 6-   �� *OnClickCommand+5      5      5      5      