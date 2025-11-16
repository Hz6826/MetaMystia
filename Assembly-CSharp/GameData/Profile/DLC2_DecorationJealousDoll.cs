using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.EventUtility;

namespace GameData.Profile
{
	// Token: 0x02000310 RID: 784
	public class DLC2_DecorationJealousDoll : DecorationBase
	{
		// Token: 0x06005D32 RID: 23858 RVA: 0x001D4744 File Offset: 0x001D2944
		// Note: this type is marked as 'beforefieldinit'.
		static DLC2_DecorationJealousDoll()
		{
			Il2CppClassPointerStore<DLC2_DecorationJealousDoll>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC2_DecorationJealousDoll");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationJealousDoll>.NativeClassPtr);
			DLC2_DecorationJealousDoll.NativeFieldInfoPtr_buffNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationJealousDoll>.NativeClassPtr, "buffNum");
			DLC2_DecorationJealousDoll.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationJealousDoll>.NativeClassPtr, 100682499);
			DLC2_DecorationJealousDoll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationJealousDoll>.NativeClassPtr, 100682500);
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x001D47B0 File Offset: 0x001D29B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232910, XrefRangeEnd = 232911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC2_DecorationJealousDoll.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x001D4800 File Offset: 0x001D2A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232911, XrefRangeEnd = 232912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC2_DecorationJealousDoll() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationJealousDoll>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationJealousDoll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x00032DB5 File Offset: 0x00030FB5
		public DLC2_DecorationJealousDoll(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06005D36 RID: 23862 RVA: 0x001D483C File Offset: 0x001D2A3C
		// (set) Token: 0x06005D37 RID: 23863 RVA: 0x00032DBE File Offset: 0x00030FBE
		public unsafe int buffNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationJealousDoll.NativeFieldInfoPtr_buffNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationJealousDoll.NativeFieldInfoPtr_buffNum)) = value;
			}
		}

		// Token: 0x04003DAC RID: 15788
		private static readonly IntPtr NativeFieldInfoPtr_buffNum;

		// Token: 0x04003DAD RID: 15789
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003DAE RID: 15790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
