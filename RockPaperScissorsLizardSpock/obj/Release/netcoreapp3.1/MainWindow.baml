   M S B A M L   `   `   `  ���� W  SRockPaperScissorsLizardSpock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:RockPaperScissorsLizardSpockRockPaperScissorsLizardSpock  -    'RockPaperScissorsLizardSpock.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:RockPaperScissorsLizardSpock       � Title$+  %RockPaperScissorsLizardSpock         ��$	��465��$	��788�� � Icon$ 
/icons.png��.��� $��	0,0,-2,-6q����	#FFF0E7E7 � RowDefinitions �� $	��21* ��� $	��19* � � ColumnDefinitions �� $	��70* ��� $��0* ��� $��0* ��� $��0* ��� $��0* ��� $��0* ��� $	��27* ��� $
��693* �.+��� -   $�� ��$��7��$
��Left=�$��182,145,0,0q�$	��Top=�$��99��$	��119�� J� RenderTransformOrigin$ 0.5,0.5&�$��2��$��0,0,0,0q�z�V� .~��� �� ��  �� Angle$ 4.421Q�T� ����  �� ImageSource$ /scissors.png���� -   $�� ��$��7��$
��Left=�$��
43,154,0,0q�$	��Top=�$	��101��$	��115��$ 0.5,0.5&�$��2��$��0,0,0,0q�z�V� .~��� �� �� $ -15.227Q�T� ���� $ 
/paper.jpg���� -   $�� ��$��7��$
��Left=�$��553,107,0,0q�$	��Top=�$��67��$��92��$��1��$��0,0,0,0q����� $ 
/reset.jpg���� -   $�� ��$��7��$
��Left=�$��320,151,0,0q�$	��Top=�$	��100��$	��121��$ 0.5,0.5&�$��2��$��0,0,0,0q�z�V� .~��� �� �� $ -16.024Q�T� ���� $ /lizard.png���� -   $�� ��$��7��$
��Left=�$��464,145,0,0q�$	��Top=�$��99��$	��108��$ 0.5,0.5&�$��2��z�V� .~��� �� �� $ 5.847Q�T� ���� $ 
/spock.jpg���� -   $�� ��$
��Left=�$��
14,161,0,0q�$	��Top=�$	��101��$	��108��$ 0.5,0.5&�$��2��$��8��$��0,0,0,0q�z�V� .~��� �� �� $ 6.787Q�T� ���� $ 	/rock.png���� -    ��Name$
 scrn��$
��Left=�$��	23,32,0,0q�$6��0WELCOME TO ROCK, PAPER, SCISSORS, LIZARD & SPOCK��$
��Wrap=�$	��Top=�$��71��$	��563��$��7��$��18(�$��Normal$��� -   $	 hmn��$��7��$
��Left=�$��200,121,0,0q�$��0��$
��Wrap=�$	��Top=�$��55��$��98��$��36(�$��1���� -	   $	 cmp��$��7��$
��Left=�$��418,119,0,0q�$��0��$
��Wrap=�$	��Top=�$��40��$��93��$��36(�$��1������ �� $��7��$
��Left=�$��219,102,0,0q�$��	TextBlock��$
��Wrap=�$	��Top=�$��0��$ 0.5,0.5&�$��1��z�V� .~���  �� ScaleY$ -1Q��� �� T� �� -
   	 ��Name$	 nsets��$
��Left=�$��	4,140,0,0q�$��3��
 �� TextWrapping$

 Wrap=�$	��Top=�$��38��$��18(�$��1��$��7���� $��YOUR score :��$��7��$
��Left=�$��120,136,0,0q�$��1��$	��Top=��� $��ALIEN score :��$��7��$
��Left=�$��336,136,0,0q�$��1��$	��Top=��� $��Number of Sets :��$
��Left=�$��
-2,137,0,0q�$��1��$	��Top=�$��8��$��23��$	��122��