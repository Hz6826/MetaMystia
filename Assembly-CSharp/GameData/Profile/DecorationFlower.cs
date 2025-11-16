using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.EventUtility;

namespace GameData.Profile
{
	// Token: 0x0200030B RID: 779
	public class DecorationFlower : DecorationBase
	{
		// Token: 0x06005D0C RID: 23820 RVA: 0x001D40AC File Offset: 0x001D22AC
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationFlower()
		{
			Il2CppClassPointerStore<DecorationFlower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationFlower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationFlower>.NativeClassPtr);
			DecorationFlower.NativeFieldInfoPtr_extraMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationFlower>.NativeClassPtr, "extraMood");
			DecorationFlower.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationFlower>.NativeClassPtr, 100682487);
			DecorationFlower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationFlower>.NativeClassPtr, 100682488);
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x001D4118 File Offset: 0x001D2318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232857, XrefRangeEnd = 232858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationFlower.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x001D4168 File Offset: 0x001D2368
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationFlower() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationFlower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationFlower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x00032C91 File Offset: 0x00030E91
		public DecorationFlower(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x001D41A4 File Offset: 0x001D23A4
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x00032C9A File Offset: 0x00030E9A
		public unsafe int extraMood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationFlower.NativeFieldInfoPtr_extraMood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationFlower.NativeFieldInfoPtr_extraMood)) = value;
			}
		}

		// Token: 0x04003D99 RID: 15769
		private static readonly IntPtr NativeFieldInfoPtr_extraMood;

		// Token: 0x04003D9A RID: 15770
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003D9B RID: 15771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
