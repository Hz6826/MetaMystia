using System;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.TimelineExtestion
{
	// Token: 0x0200044B RID: 1099
	public class COM_CommonPannels_Open_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007997 RID: 31127 RVA: 0x00231C4C File Offset: 0x0022FE4C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_CommonPannels_Open_Behaviour()
		{
			Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_CommonPannels_Open_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr);
			COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_NoteBookGotoType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr, "NoteBookGotoType");
			COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_PannelOpenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr, "PannelOpenType");
			COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_StorageGotoType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr, "StorageGotoType");
			COM_CommonPannels_Open_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr, 100687743);
			COM_CommonPannels_Open_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr, 100687744);
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x00231CE0 File Offset: 0x0022FEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294119, XrefRangeEnd = 294140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_CommonPannels_Open_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00231D1C File Offset: 0x0022FF1C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_CommonPannels_Open_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_CommonPannels_Open_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x00041ADB File Offset: 0x0003FCDB
		public COM_CommonPannels_Open_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600799B RID: 31131 RVA: 0x00231D58 File Offset: 0x0022FF58
		// (set) Token: 0x0600799C RID: 31132 RVA: 0x00041AE4 File Offset: 0x0003FCE4
		public unsafe NoteBookMainPannel.GoToSpecificType NoteBookGotoType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_NoteBookGotoType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_NoteBookGotoType)) = value;
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x00231D80 File Offset: 0x0022FF80
		// (set) Token: 0x0600799E RID: 31134 RVA: 0x00041AFF File Offset: 0x0003FCFF
		public unsafe COM_CommonPannels_Open_Behaviour.PannelType PannelOpenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_PannelOpenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_PannelOpenType)) = value;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600799F RID: 31135 RVA: 0x00231DA8 File Offset: 0x0022FFA8
		// (set) Token: 0x060079A0 RID: 31136 RVA: 0x00041B1A File Offset: 0x0003FD1A
		public unsafe StorageMainPannel.GoToSpecificType StorageGotoType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_StorageGotoType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_CommonPannels_Open_Behaviour.NativeFieldInfoPtr_StorageGotoType)) = value;
			}
		}

		// Token: 0x04005002 RID: 20482
		private static readonly IntPtr NativeFieldInfoPtr_NoteBookGotoType;

		// Token: 0x04005003 RID: 20483
		private static readonly IntPtr NativeFieldInfoPtr_PannelOpenType;

		// Token: 0x04005004 RID: 20484
		private static readonly IntPtr NativeFieldInfoPtr_StorageGotoType;

		// Token: 0x04005005 RID: 20485
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04005006 RID: 20486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F8B RID: 3979
		public enum PannelType
		{
			// Token: 0x0400AE34 RID: 44596
			NoteBook,
			// Token: 0x0400AE35 RID: 44597
			Storage
		}

		// Token: 0x02000F8C RID: 3980
		[ObfuscatedName("Common.TimelineExtestion.COM_CommonPannels_Open_Behaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0601139A RID: 70554 RVA: 0x003F80E0 File Offset: 0x003F62E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr);
				COM_CommonPannels_Open_Behaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr, "<>9");
				COM_CommonPannels_Open_Behaviour.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr, "<>9__4_0");
				COM_CommonPannels_Open_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr, 100687746);
				COM_CommonPannels_Open_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__4_0_Internal_Void_UISubPanel_1_NoteBookMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr, 100687747);
			}

			// Token: 0x0601139B RID: 70555 RVA: 0x003F815C File Offset: 0x003F635C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_CommonPannels_Open_Behaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_CommonPannels_Open_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601139C RID: 70556 RVA: 0x003F8198 File Offset: 0x003F6398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294116, XrefRangeEnd = 294119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__4_0(UISubPanel<NoteBookMainPannel> panel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_CommonPannels_Open_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__4_0_Internal_Void_UISubPanel_1_NoteBookMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601139D RID: 70557 RVA: 0x00095BF3 File Offset: 0x00093DF3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005983 RID: 22915
			// (get) Token: 0x0601139E RID: 70558 RVA: 0x003F81DC File Offset: 0x003F63DC
			// (set) Token: 0x0601139F RID: 70559 RVA: 0x00095BFC File Offset: 0x00093DFC
			public unsafe static COM_CommonPannels_Open_Behaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_CommonPannels_Open_Behaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<COM_CommonPannels_Open_Behaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_CommonPannels_Open_Behaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005984 RID: 22916
			// (get) Token: 0x060113A0 RID: 70560 RVA: 0x003F8204 File Offset: 0x003F6404
			// (set) Token: 0x060113A1 RID: 70561 RVA: 0x00095C0E File Offset: 0x00093E0E
			public unsafe static Action<UISubPanel<NoteBookMainPannel>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_CommonPannels_Open_Behaviour.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UISubPanel<NoteBookMainPannel>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_CommonPannels_Open_Behaviour.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE36 RID: 44598
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AE37 RID: 44599
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400AE38 RID: 44600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE39 RID: 44601
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__4_0_Internal_Void_UISubPanel_1_NoteBookMainPannel_0;
		}
	}
}
