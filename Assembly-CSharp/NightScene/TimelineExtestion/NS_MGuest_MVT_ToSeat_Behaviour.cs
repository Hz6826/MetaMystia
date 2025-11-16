using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E2 RID: 482
	public class NS_MGuest_MVT_ToSeat_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C4C RID: 15436 RVA: 0x0016B904 File Offset: 0x00169B04
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_MVT_ToSeat_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_MVT_ToSeat_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr);
			NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, "deskCode");
			NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, "label");
			NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_mood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, "mood");
			NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			NS_MGuest_MVT_ToSeat_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, 100674482);
			NS_MGuest_MVT_ToSeat_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, 100674483);
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x0016B9AC File Offset: 0x00169BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136732, XrefRangeEnd = 136769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_MVT_ToSeat_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0016B9E8 File Offset: 0x00169BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_MVT_ToSeat_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_ToSeat_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00021D4C File Offset: 0x0001FF4C
		public NS_MGuest_MVT_ToSeat_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x0016BA24 File Offset: 0x00169C24
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x00021D55 File Offset: 0x0001FF55
		public unsafe int deskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_deskCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_deskCode)) = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x0016BA4C File Offset: 0x00169C4C
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x00021D70 File Offset: 0x0001FF70
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x0016BA74 File Offset: 0x00169C74
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x00021D8F File Offset: 0x0001FF8F
		public unsafe int mood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_mood);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_mood)) = value;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x0016BA9C File Offset: 0x00169C9C
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x00021DAA File Offset: 0x0001FFAA
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_MVT_ToSeat_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeFieldInfoPtr_deskCode;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeFieldInfoPtr_mood;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200097C RID: 2428
		[ObfuscatedName("NightScene.TimelineExtestion.NS_MGuest_MVT_ToSeat_Behaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600BC5C RID: 48220 RVA: 0x002F5F28 File Offset: 0x002F4128
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr);
				NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr, "<>9");
				NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr, "<>9__4_0");
				NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr, "<>9__4_1");
				NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr, 100674485);
				NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__4_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr, 100674486);
				NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__4_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr, 100674487);
			}

			// Token: 0x0600BC5D RID: 48221 RVA: 0x002F5FCC File Offset: 0x002F41CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_MVT_ToSeat_Behaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC5E RID: 48222 RVA: 0x002F6008 File Offset: 0x002F4208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136729, XrefRangeEnd = 136732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__4_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC5F RID: 48223 RVA: 0x002F603C File Offset: 0x002F423C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__4_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__4_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC60 RID: 48224 RVA: 0x0006586C File Offset: 0x00063A6C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8D RID: 15757
			// (get) Token: 0x0600BC61 RID: 48225 RVA: 0x002F6070 File Offset: 0x002F4270
			// (set) Token: 0x0600BC62 RID: 48226 RVA: 0x00065875 File Offset: 0x00063A75
			public unsafe static NS_MGuest_MVT_ToSeat_Behaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NS_MGuest_MVT_ToSeat_Behaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8E RID: 15758
			// (get) Token: 0x0600BC63 RID: 48227 RVA: 0x002F6098 File Offset: 0x002F4298
			// (set) Token: 0x0600BC64 RID: 48228 RVA: 0x00065887 File Offset: 0x00063A87
			public unsafe static Action __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8F RID: 15759
			// (get) Token: 0x0600BC65 RID: 48229 RVA: 0x002F60C0 File Offset: 0x002F42C0
			// (set) Token: 0x0600BC66 RID: 48230 RVA: 0x00065899 File Offset: 0x00063A99
			public unsafe static Action __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NS_MGuest_MVT_ToSeat_Behaviour.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040079A8 RID: 31144
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040079A9 RID: 31145
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040079AA RID: 31146
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040079AB RID: 31147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079AC RID: 31148
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__4_0_Internal_Void_0;

			// Token: 0x040079AD RID: 31149
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__4_1_Internal_Void_0;
		}
	}
}
