SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
Image image = new Image();
image.Source = "friends.jpg";
image.HeightRequest = 70;
image.WidthRequest = 60;
sfBadgeView.Content = image;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Type = BadgeType.Warning;
badgeSetting.Icon = BadgeIcon.Away;
badgeSetting.Position = BadgePosition.BottomRight;
badgeSetting.Offset = new Point(0, -10);
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    