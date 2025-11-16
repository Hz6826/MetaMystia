using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A4 RID: 676
	[Serializable]
	public class KyoukoTutorialDataContainsTimeline : KyoukoTutorialData
	{
		// Token: 0x060055EB RID: 21995 RVA: 0x001C0248 File Offset: 0x001BE448
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialDataContainsTimeline()
		{
			Il2CppClassPointerStore<KyoukoTutorialDataContainsTimeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialDataContainsTimeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataContainsTimeline>.NativeClassPtr);
			KyoukoTutorialDataContainsTimeline.NativeFieldInfoPtr_tutorialTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataContainsTimeline>.NativeClassPtr, "tutorialTimeline");
			KyoukoTutorialDataContainsTimeline.NativeFieldInfoPtr_tutorialTimelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataContainsTimeline>.NativeClassPtr, "tutorialTimelineAsset");
			KyoukoTutorialDataContainsTimeline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataContainsTimeline>.NativeClassPtr, 100680804);
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x001C02B4 File Offset: 0x001BE4B4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialDataContainsTimeline() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataContainsTimeline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataContainsTimeline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x0002E446 File Offset: 0x0002C646
		public KyoukoTutorialDataContainsTimeline(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x060055EE RID: 21998 RVA: 0x001C02F0 File Offset: 0x001BE4F0
		// (set) Token: 0x060055EF RID: 21999 RVA: 0x0002E44F File Offset: 0x0002C64F
		public unsafe PlayableAsset tutorialTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataContainsTimeline.NativeFieldInfoPtr_tutorialTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataContainsTimeline.NativeFieldInfoPtr_tutorialTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x001C0320 File Offset: 0x001BE520
		// (set) Token: 0x060055F1 RID: 22001 RVA: 0x0002E46E File Offset: 0x0002C66E
		public unsafe AssetReference tutorialTimelineAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataContainsTimeline.NativeFieldInfoPtr_tutorialTimelineAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataContainsTimeline.NativeFieldInfoPtr_tutorialTimelineAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeFieldInfoPtr_tutorialTimeline;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeFieldInfoPtr_tutorialTimelineAsset;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
