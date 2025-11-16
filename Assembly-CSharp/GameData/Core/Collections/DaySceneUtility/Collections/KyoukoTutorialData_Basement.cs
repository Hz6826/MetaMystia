using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002AD RID: 685
	[Serializable]
	public class KyoukoTutorialData_Basement : KyoukoTutorialDataMultipleChoice
	{
		// Token: 0x0600563E RID: 22078 RVA: 0x001C120C File Offset: 0x001BF40C
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_Basement()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_Basement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr);
			KyoukoTutorialData_Basement.NativeFieldInfoPtr_ShowCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr, "ShowCase");
			KyoukoTutorialData_Basement.NativeFieldInfoPtr_Closet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr, "Closet");
			KyoukoTutorialData_Basement.NativeFieldInfoPtr_CdPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr, "CdPlayer");
			KyoukoTutorialData_Basement.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr, 100680859);
			KyoukoTutorialData_Basement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr, 100680860);
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x001C12A0 File Offset: 0x001BF4A0
		public unsafe override Il2CppReferenceArray<KyoukoTutorialData> ChildKyoukoTutorialData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214349, XrefRangeEnd = 214358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_Basement.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KyoukoTutorialData>>(intPtr3) : null;
			}
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x001C12EC File Offset: 0x001BF4EC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_Basement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_Basement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_Basement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x0002E6F6 File Offset: 0x0002C8F6
		public KyoukoTutorialData_Basement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x001C1328 File Offset: 0x001BF528
		// (set) Token: 0x06005643 RID: 22083 RVA: 0x0002E6FF File Offset: 0x0002C8FF
		public unsafe KyoukoTutorialData_ShowCase ShowCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Basement.NativeFieldInfoPtr_ShowCase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_ShowCase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Basement.NativeFieldInfoPtr_ShowCase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06005644 RID: 22084 RVA: 0x001C1358 File Offset: 0x001BF558
		// (set) Token: 0x06005645 RID: 22085 RVA: 0x0002E71E File Offset: 0x0002C91E
		public unsafe KyoukoTutorialData_Closet Closet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Basement.NativeFieldInfoPtr_Closet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_Closet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Basement.NativeFieldInfoPtr_Closet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x001C1388 File Offset: 0x001BF588
		// (set) Token: 0x06005647 RID: 22087 RVA: 0x0002E73D File Offset: 0x0002C93D
		public unsafe KyoukoTutorialData_CDPlayer CdPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Basement.NativeFieldInfoPtr_CdPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_CDPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_Basement.NativeFieldInfoPtr_CdPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039D2 RID: 14802
		private static readonly IntPtr NativeFieldInfoPtr_ShowCase;

		// Token: 0x040039D3 RID: 14803
		private static readonly IntPtr NativeFieldInfoPtr_Closet;

		// Token: 0x040039D4 RID: 14804
		private static readonly IntPtr NativeFieldInfoPtr_CdPlayer;

		// Token: 0x040039D5 RID: 14805
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0;

		// Token: 0x040039D6 RID: 14806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
